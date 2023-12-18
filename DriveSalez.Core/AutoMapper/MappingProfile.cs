using AutoMapper;
using DriveSalez.Core.DTO;
using DriveSalez.Core.Entities;

namespace DriveSalez.Infrastructure.AutoMapper;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        
        CreateMap<Announcement, AnnouncementResponseMiniDto>()
            .ForMember(dest => dest.ImageUrl, opt => opt.MapFrom(src => src.ImageUrls[0]))
            .ForMember(dest => dest.Year, opt => opt.MapFrom(src => src.Vehicle.Year))
            .ForMember(dest => dest.Make, opt => opt.MapFrom(src => src.Vehicle.Make))
            .ForMember(dest => dest.Model, opt => opt.MapFrom(src => src.Vehicle.Model))
            .ForMember(dest => dest.FuelType, opt => opt.MapFrom(src => src.Vehicle.FuelType))
            .ForMember(dest => dest.EngineVolume, opt => opt.MapFrom(src => src.Vehicle.VehicleDetails.EngineVolume))
            .ForMember(dest => dest.Mileage, opt => opt.MapFrom(src => src.Vehicle.VehicleDetails.MileAge))
            .ForMember(dest => dest.MileageType, opt => opt.MapFrom(src => src.Vehicle.VehicleDetails.MileageType));
        
       CreateMap<Announcement, AnnouncementResponseDto>()
            .ForMember(dest => dest.Year, opt => opt.MapFrom(src => src.Vehicle.Year))
            .ForMember(dest => dest.Make, opt => opt.MapFrom(src => src.Vehicle.Make))
            .ForMember(dest => dest.Model, opt => opt.MapFrom(src => src.Vehicle.Model))
            .ForMember(dest => dest.FuelType, opt => opt.MapFrom(src => src.Vehicle.FuelType))
            .ForMember(dest => dest.IsBrandNew, opt => opt.MapFrom(src => src.Vehicle.IsBrandNew))
            .ForMember(dest => dest.BodyType, opt => opt.MapFrom(src => src.Vehicle.VehicleDetails.BodyType))
            .ForMember(dest => dest.Color, opt => opt.MapFrom(src => src.Vehicle.VehicleDetails.Color))
            .ForMember(dest => dest.HorsePower, opt => opt.MapFrom(src => src.Vehicle.VehicleDetails.HorsePower))
            .ForMember(dest => dest.GearboxType, opt => opt.MapFrom(src => src.Vehicle.VehicleDetails.GearboxType))
            .ForMember(dest => dest.DrivetrainType, opt => opt.MapFrom(src => src.Vehicle.VehicleDetails.DrivetrainType))
            .ForMember(dest => dest.Conditions, opt => opt.MapFrom(src => src.Vehicle.VehicleDetails.Conditions))
            .ForMember(dest => dest.MarketVersion, opt => opt.MapFrom(src => src.Vehicle.VehicleDetails.MarketVersion))
            .ForMember(dest => dest.OwnerQuantity, opt => opt.MapFrom(src => src.Vehicle.VehicleDetails.OwnerQuantity))
            .ForMember(dest => dest.SeatCount, opt => opt.MapFrom(src => src.Vehicle.VehicleDetails.SeatCount))
            .ForMember(dest => dest.VinCode, opt => opt.MapFrom(src => src.Vehicle.VehicleDetails.VinCode))
            .ForMember(dest => dest.Options, opt => opt.MapFrom(src => src.Vehicle.VehicleDetails.Options))
            .ForMember(dest => dest.EngineVolume, opt => opt.MapFrom(src => src.Vehicle.VehicleDetails.EngineVolume))
            .ForMember(dest => dest.Mileage, opt => opt.MapFrom(src => src.Vehicle.VehicleDetails.MileAge))
            .ForMember(dest => dest.MileageType, opt => opt.MapFrom(src => src.Vehicle.VehicleDetails.MileageType))
            .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.Owner.Id))
            .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.Owner.UserName))
            .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Owner.Email))
            .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.Owner.FirstName))
            .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.Owner.LastName))
            .ForMember(dest => dest.PhoneNumbers, opt => opt.MapFrom(src => src.Owner.PhoneNumbers));
    }
} 