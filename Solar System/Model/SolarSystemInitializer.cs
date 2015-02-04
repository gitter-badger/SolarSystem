using System;
using System.Collections.Generic;
using System.Data.Entity;
using Model.Models;

namespace Model
{
    public class SolarSystemInitializer : DropCreateDatabaseIfModelChanges<SolarSystemContext>
    {
        protected override void Seed(SolarSystemContext context)
        {
            var sun = new SpaceObject
             {
                 Id = Guid.NewGuid(),
                 Name = "Sun",
                 IsCenter = true,
                 Radius = 695510,
                 Type = SpaceObjectType.Star
             };

            var planets = new List<SpaceObject>();

            //var mercury = PlanetCreator("Mercury", sun.Id, 5, 10, 10, 88);
            //var venus = PlanetCreator("Venus", sun.Id, 12.1, 60, 60, 224);
            //var earth = PlanetCreator("Earth", sun.Id, 13.2, 110, 110, 365);
            var earth = new SpaceObject
            {
                Name = "Earth",
                Radius = 6.4,
                Aphelion = 152098,
                Perihelion = 147098,
                OrbitalPeriod = 365,
                Eccentricity = 0.01671123,
                Id = Guid.NewGuid(),
                SpaceObjectId = sun.Id,
                SemiMajorAxis = 149598,
                Type = SpaceObjectType.Planet
            };
            var mercury = new SpaceObject
            {
                Name = "Mercury",
                Radius = 2.4,
                Aphelion = 69817,
                Perihelion = 46001,
                OrbitalPeriod = 88,
                Eccentricity = 0.20563593,
                Id = Guid.NewGuid(),
                SpaceObjectId = sun.Id,
                SemiMajorAxis = 57909,
                Type = SpaceObjectType.Planet
            };
            var venus = new SpaceObject
            {
                Name = "Venus",
                Radius = 6,
                Aphelion = 108942,
                Perihelion = 107476,
                OrbitalPeriod = 224.7,
                Eccentricity = 0.0068,
                Id = Guid.NewGuid(),
                SpaceObjectId = sun.Id,
                SemiMajorAxis = 108209,
                Type = SpaceObjectType.Planet,
                IsRetrograde = true
            };
            var mars = new SpaceObject
            {
                Name = "Mars",
                Radius = 3.4,
                Aphelion = 249232,
                Perihelion = 206655,
                OrbitalPeriod = 687,
                Eccentricity = 0.0933941,
                Id = Guid.NewGuid(),
                SpaceObjectId = sun.Id,
                SemiMajorAxis = 227944,
                Type = SpaceObjectType.Planet,
            };
            var jupiter = new SpaceObject
            {
                Name = "Jupiter",
                Radius = 70,
                Aphelion = 816520,
                Perihelion = 740573,
                OrbitalPeriod = 4332.6,
                Eccentricity = 0.048775,
                Id = Guid.NewGuid(),
                SpaceObjectId = sun.Id,
                SemiMajorAxis = 778547,
                Type = SpaceObjectType.Planet,
            };
            var saturn = new SpaceObject
            {
                Name = "Saturn",
                Radius = 60.2,
                Aphelion = 1513326,
                Perihelion = 1353573,
                OrbitalPeriod = 10759,
                Eccentricity = 0.055723219,
                Id = Guid.NewGuid(),
                SpaceObjectId = sun.Id,
                SemiMajorAxis = 1433449,
                Type = SpaceObjectType.Planet,
            };
            var uranus = new SpaceObject
            {
                Name = "Uranus",
                Radius = 25.6,
                Aphelion = 3004420,
                Perihelion = 2748939,
                OrbitalPeriod = 30685,
                Eccentricity = 0.044405586,
                Id = Guid.NewGuid(),
                SpaceObjectId = sun.Id,
                SemiMajorAxis = 2876679,
                Type = SpaceObjectType.Planet,
                IsRetrograde = true
            };
            var neptune = new SpaceObject
            {
                Name = "Neptune",
                Radius = 24.7,
                Aphelion = 4553946,
                Perihelion = 4452940,
                OrbitalPeriod = 60190,
                Eccentricity = 0.011214269,
                Id = Guid.NewGuid(),
                SpaceObjectId = sun.Id,
                SemiMajorAxis = 4503444,
                Type = SpaceObjectType.Planet,
            };


            //var mars = PlanetCreator("Mars", sun.Id, 6.8, 160, 160, 687);
            //var jupiter = PlanetCreator("Jupiter", sun.Id, 41.1, 300, 300, 4332);
            //var saturn = PlanetCreator("Saturn", sun.Id, 34.6, 400, 400, 10759);
            //var uranus = PlanetCreator("Uranus", sun.Id, 20, 700, 700, 30685);
            //var neptune = PlanetCreator("Neptune", sun.Id, 14.2, 900, 900, 60190);

            planets.AddRange(new List<SpaceObject>
            {
                mercury,venus,earth,mars,jupiter,saturn,uranus,neptune
            });

            //var satellites = new List<SpaceObject>();

            //var moon = new SpaceObject
            //{
            //    Name = "Moon",
            //    Radius = 1.7,
            //    Aphelion = 406,
            //    Perihelion = 363,
            //    OrbitalPeriod = 27.3,
            //    SemiMajorAxis = 384,
            //    Eccentricity = 0.0549,
            //    Id = Guid.NewGuid(),
            //    SpaceObjectId = earth.Id,
            //    Type = SpaceObjectType.Moon
            //};

            //satellites.Add(moon);

            context.SpaceObjects.Add(sun);
            context.SpaceObjects.AddRange(planets);
            //context.SpaceObjects.AddRange(satellites);
            context.SaveChanges();
        }
    }
}
