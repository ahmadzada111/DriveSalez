using DriveSalez.Core.Enums;
using DriveSalez.Infrastructure.DbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Quartz;

namespace DriveSalez.Infrastructure.Quartz.Jobs;

public class DeleteInactiveAccountsJob : IJob
{
    private readonly ApplicationDbContext _dbContext;
    private readonly ILogger _logger;
    
    public DeleteInactiveAccountsJob(ApplicationDbContext dbContext, ILogger<DeleteInactiveAccountsJob> logger)
    {
        _dbContext = dbContext;
        _logger = logger;
    }

    public async Task Execute(IJobExecutionContext context)
    {
        _logger.LogInformation($"{typeof(DeleteInactiveAccountsJob)} job started");
        
        var inactiveAccounts = await _dbContext.Users
            .Where(a => !a.EmailConfirmed)
            .ToListAsync();
        
        _dbContext.Users.RemoveRange(inactiveAccounts);
        
        await _dbContext.SaveChangesAsync();
        
        _logger.LogInformation($"{typeof(DeleteInactiveAccountsJob)} job started");
    }
}