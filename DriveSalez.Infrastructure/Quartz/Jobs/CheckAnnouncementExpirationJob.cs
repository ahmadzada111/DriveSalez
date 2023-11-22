using DriveSalez.Core.Enums;
using DriveSalez.Core.ServiceContracts;
using DriveSalez.Infrastructure.DbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Quartz;

namespace DriveSalez.Infrastructure.Quartz.Jobs;

public class CheckAnnouncementExpirationJob : IJob
{
    private readonly ApplicationDbContext _dbContext;
    private readonly ILogger _logger;
    private readonly IEmailService _emailService;
    
    public CheckAnnouncementExpirationJob(ApplicationDbContext dbContext, ILogger<CheckAnnouncementExpirationJob> logger,
        IEmailService emailService)
    {
        _dbContext = dbContext;
        _logger = logger;
        _emailService = emailService;
    }

    public async Task Execute(IJobExecutionContext context)
    {
        _logger.LogInformation($"{typeof(CheckAnnouncementExpirationJob)} job started");
        
        var expiredAnnouncements = await _dbContext.Announcements
            .Where(a => a.AnnouncementState == AnnouncementState.Active && a.ExpirationDate <= DateTimeOffset.Now)
            .Include(a => a.Owner)
            .Include(a => a.Vehicle)
            .Include(a => a.Vehicle.Make)
            .Include(a => a.Vehicle.Model)
            .ToListAsync();
        
        foreach (var announcement in expiredAnnouncements)
        {
            announcement.AnnouncementState = AnnouncementState.Inactive;

            string subject = "Activate Your Expired Announcement";
            string body = $"Dear {announcement.Owner.FirstName} {announcement.Owner.FirstName}," +
                          $"\n\nWe hope this message finds you well. " +
                          $"We're reaching out to inform you that the expiration date for your announcement on {announcement.Vehicle.Make} {announcement.Vehicle.Model} has passed as of {announcement.ExpirationDate}." +
                          $"\n\nAs a reminder, our service keeps announcements active for a month from the initial posting date. " +
                          $"Once this period expires, announcements become inactive. " +
                          $"To continue benefiting from the exposure your announcement provides, we encourage you to manually reactivate it." +
                          $"\n\nHere's how to reactivate your announcement:\n\nLog in to your {announcement.Owner.UserName} account." +
                          $"\nNavigate to your dashboard or announcements section." +
                          $"\nLocate the expired announcement and follow the prompts to reactivate." +
                          $"\nAct now to ensure your announcement continues to reach our community and attract potential buyers. " +
                          $"If you have any questions or encounter any issues during the reactivation process, feel free to reach out to our support team." +
                          $"\n\nThank you for choosing DriveSalez. We appreciate your continued use of our platform." +
                          $"\n\nBest regards,\n\nDriveSalez Team";

            _emailService.SendEmailAsync(announcement.Owner.Email, subject, body);
        }
        
        _dbContext.UpdateRange(expiredAnnouncements);
        await _dbContext.SaveChangesAsync();
        
        _logger.LogInformation($"{typeof(CheckAnnouncementExpirationJob)} job finished");
    }
}