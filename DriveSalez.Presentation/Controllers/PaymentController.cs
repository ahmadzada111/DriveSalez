using DriveSalez.Application.ServiceContracts;
using DriveSalez.Domain.Exceptions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DriveSalez.Presentation.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PaymentController : Controller
{
    private readonly IPaymentService _paymentService;
    private readonly ILogger _logger;
    
    public PaymentController(IPaymentService paymentService, ILogger<PaymentController> logger)
    {
        _paymentService = paymentService;
        _logger = logger;
    }
    
    // [Authorize]
    // [HttpPost("top-up-balance")]
    // public async Task<ActionResult> TopUpBalance([FromBody] PaymentRequestDto request)
    // {
    //     _logger.LogInformation($"[{DateTime.Now.ToLongTimeString()}] Path: {HttpContext.Request.Path}");
    //     
    //     var result = await _paymentService.TopUpBalance(request); 
    //     return result ? Ok() : BadRequest();
    // }
    //
    // [Authorize]
    // [HttpPost("add-regular-announcement-limit")]
    // public async Task<ActionResult> AddRegularAnnouncementLimit([FromBody] int announcementQuantity, int subscriptionId)
    // {
    //     _logger.LogInformation($"[{DateTime.Now.ToLongTimeString()}] Path: {HttpContext.Request.Path}");
    //     
    //     var result = await _paymentService.AddRegularAnnouncementLimit(announcementQuantity, subscriptionId);
    //     return result ? Ok() : BadRequest();
    // }
    //
    // [Authorize]
    // [HttpPost("add-premium-announcement-limit")]
    // public async Task<ActionResult> AddPremiumAnnouncementLimit([FromBody] int announcementQuantity, int subscriptionId)
    // {
    //     _logger.LogInformation($"[{DateTime.Now.ToLongTimeString()}] Path: {HttpContext.Request.Path}");
    //     
    //     var result = await _paymentService.AddPremiumAnnouncementLimit(announcementQuantity, subscriptionId);
    //     return result ? Ok() : BadRequest();
    // }
    
    [Authorize]
    [HttpPost("add-announcement-limit")]
    public async Task<ActionResult> AddAnnouncementLimit([FromBody] int announcementQuantity, int subscriptionId)
    {
        _logger.LogInformation($"[{DateTime.Now.ToLongTimeString()}] Path: {HttpContext.Request.Path}");
        
        var result = await _paymentService.AddAnnouncementLimit(announcementQuantity, subscriptionId);
        return result ? Ok() : BadRequest();
    }
    
    [HttpPost("buy-premium-account")]
    public async Task<ActionResult> BuyPremiumAccount(int subscriptionId)
    {
        _logger.LogInformation($"[{DateTime.Now.ToLongTimeString()}] Path: {HttpContext.Request.Path}");
        
        var result = await _paymentService.BuyPremiumAccount(subscriptionId);
        return result ? Ok() : BadRequest();
    }
    
    [HttpPost("buy-business-account")]
    public async Task<ActionResult> BuyBusinessAccount(int subscriptionId)
    {
        _logger.LogInformation($"[{DateTime.Now.ToLongTimeString()}] Path: {HttpContext.Request.Path}");
        
        var result = await _paymentService.BuyBusinessAccount(subscriptionId);
        return result ? Ok() : BadRequest();
    }
}