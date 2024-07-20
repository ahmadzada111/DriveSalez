using DriveSalez.Application.DTO;
using DriveSalez.Application.DTO.AccountDTO;
using Microsoft.Extensions.Caching.Memory;

namespace DriveSalez.Application.ServiceContracts;

public interface IOtpService
{
    string GenerateOtp();

    Task<bool> ValidateOtpAsync(IMemoryCache cache, ValidateOtpDto request);
}