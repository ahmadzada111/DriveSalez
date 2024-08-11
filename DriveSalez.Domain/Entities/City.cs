﻿using System.Text.Json.Serialization;

namespace DriveSalez.Domain.Entities;

public class City
{
    public int Id { get; set; } 

    public string Name { get; set; }

    public int CountryId { get; set; }    

    public Country Country { get; set; }    

    public List<Announcement> Announcements { get; } = [];
}