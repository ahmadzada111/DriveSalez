using DriveSalez.Domain.Entities;
using DriveSalez.Domain.Entities.VehicleParts;

namespace DriveSalez.Application.DTO;

public class AnnouncementResponseMiniDto
{
    public Guid Id { get; set; }
    
    public Make Make { get; set; }
    
    public Model Model { get; set; }
    
    public decimal Price { get; set; }
    
    public bool IsPremium { get; set; }

    public bool Barter { get; set; }

    public bool OnCredit { get; set; }
    
    public string VinCode { get; set; }
    
    public int Mileage { get; set; }
    
    public string MileageType { get; set; }
    
    public double EngineVolume { get; set; }
    
    public VehicleFuelType FuelType { get; set; }
    
    public ManufactureYear Year { get; set; }
    
    public Currency Currency { get; set; }
    
    public ImageUrl ImageUrl { get; set; }
}