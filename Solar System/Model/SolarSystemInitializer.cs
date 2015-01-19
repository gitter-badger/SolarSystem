using System;
using System.Collections.Generic;
using Model.Models;

namespace Model
{
    public class SolarSystemInitializer
    {
        public void Seed(SolarSystemContext context)
        {
            var sunId = Guid.NewGuid();
            var sunSatellites = new List<SpaceObject>
            {
                new SpaceObject
                {
                    Id=Guid.NewGuid(),
                    PrimaryId = sunId,
                    Name = "Mercury",
                    Satellites = null,
                    Type = SpaceObjectType.Planet
                },
                new SpaceObject
                {
                    Id=Guid.NewGuid(),
                    PrimaryId = sunId,
                    Name = "Venus",
                    Satellites = null,
                    Type = SpaceObjectType.Planet
                },
                new SpaceObject
                {
                    Id=Guid.NewGuid(),
                    PrimaryId = sunId,
                    Name = "Earth",
                    Type = SpaceObjectType.Planet
                }
            };

            var spaceObjects = new List<SpaceObject>
            {
                new SpaceObject
                {
                    Id = Guid.NewGuid(), 
                    Name = "Sun", 
                    IsCenter = true, 
                    Radius = 100, 
                    Type = SpaceObjectType.Star,
                    Satellites = sunSatellites
                },
            };

            spaceObjects.ForEach(s => context.SpaceObjects.Add(s));
            context.SaveChanges();
        }
    }
}
