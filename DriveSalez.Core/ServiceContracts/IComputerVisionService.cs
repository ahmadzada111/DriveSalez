using Microsoft.Azure.CognitiveServices.Vision.ComputerVision.Models;
using Microsoft.Extensions.Configuration;
using ImageUrl = DriveSalez.Core.Entities.ImageUrl;

namespace DriveSalez.Core.ServiceContracts;

public interface IComputerVisionService
{
    Task<bool> AnalyzeImagesAsync(List<ImageUrl> imageUrls);
}