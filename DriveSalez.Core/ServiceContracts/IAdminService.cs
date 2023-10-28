﻿using DriveSalez.Core.DTO;
using DriveSalez.Core.Entities;
using DriveSalez.Core.Entities.VehicleDetailsFiles;
using DriveSalez.Core.Entities.VehicleParts;
using DriveSalez.Core.IdentityEntities;

namespace DriveSalez.Core.ServiceContracts
{
    public interface IAdminService
    {
        Task<VehicleColor> AddColorAsync(string color);

        Task<VehicleBodyType> AddBodyTypeAsync(string bodyType);

        Task<VehicleDrivetrainType> AddVehicleDrivetrainTypeAsync(string driveTrainType);

        Task<VehicleGearboxType> AddVehicleGearboxTypeAsync(string gearboxType);

        Task<Make> AddMakeAsync(string make);

        Task<Model> AddModelAsync(int makeId, string model);

        Task<VehicleFuelType> AddVehicleFuelTypeAsync(string fuelType);

        Task<VehicleCondition> AddVehicleConditionAsync(string condition);

        Task<VehicleMarketVersion> AddVehicleMarketVersionAsync(string marketVersion);

        Task<VehicleOption> AddVehicleOptionAsync(string option);

        Task<VehicleColor> UpdateVehicleColorAsync(int colorId, string newColor);

        Task<VehicleBodyType> UpdateVehicleBodyTypeAsync(int bodyTypeId, string newBodyType);

        Task<VehicleDrivetrainType> UpdateVehicleDrivetrainTypeAsync(int drivetrainId, string newDrivetrain);

        Task<VehicleGearboxType> UpdateVehicleGearboxTypeAsync(int gearboxId, string newGearbox);

        Task<Make> UpdateMakeAsync(int makeId, string newMake);

        Task<Model> UpdateModelAsync(int modelId, string newModel);

        Task<VehicleFuelType> UpdateFuelTypeAsync(int fuelTypeId, string newFuelType);

        Task<VehicleCondition> UpdateVehicleConditionAsync(int vehicleConditionId, string newVehicleCondition);

        Task<VehicleOption> UpdateVehicleOptionAsync(int vehicleOptionId, string newVehicleOption);

        Task<VehicleMarketVersion> UpdateVehicleMarketVersionAsync(int marketVersionId, string newMarketVersion);

        Task<VehicleColor> DeleteVehicleColorAsync(int colorId);

        Task<VehicleBodyType> DeleteVehicleBodyTypeAsync(int bodyTypeId);

        Task<VehicleDrivetrainType> DeleteVehicleDrivetrainTypeAsync(int drivetrainId);

        Task<VehicleGearboxType> DeleteVehicleGearboxTypeAsync(int gearboxId);

        Task<Make> DeleteMakeAsync(int makeId);

        Task<Model> DeleteModelAsync(int modelId);

        Task<VehicleFuelType> DeleteFuelTypeAsync(int fuelTypeId);

        Task<VehicleCondition> DeleteVehicleConditionAsync(int vehicleConditionId);

        Task<VehicleOption> DeleteVehicleOptionAsync(int vehicleOptionId);

        Task<VehicleMarketVersion> DeleteVehicleMarketVersionAsync(int marketVersionId);
        
        Task<ApplicationUser> AddModeratorAsync(RegisterDto registerDTO);
    }
}
