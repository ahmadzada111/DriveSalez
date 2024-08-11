﻿using System.Text.Json.Serialization;

namespace DriveSalez.Domain.Entities.VehicleDetailsFiles;

public class Option
{
    public int Id { get; set; }

    public required string Title { get; set; }
    
    public List<VehicleDetail> VehicleDetails { get; } = [];
}