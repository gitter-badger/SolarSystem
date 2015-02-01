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
                Name="Earth",
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

            //var mars = PlanetCreator("Mars", sun.Id, 6.8, 160, 160, 687);
            //var jupiter = PlanetCreator("Jupiter", sun.Id, 41.1, 300, 300, 4332);
            //var saturn = PlanetCreator("Saturn", sun.Id, 34.6, 400, 400, 10759);
            //var uranus = PlanetCreator("Uranus", sun.Id, 20, 700, 700, 30685);
            //var neptune = PlanetCreator("Neptune", sun.Id, 14.2, 900, 900, 60190);

            planets.AddRange(new List<SpaceObject>
            {
                earth
                //mercury,venus,earth,mars,jupiter,saturn,uranus,neptune
            });

            //var satellites = new List<SpaceObject>();
            //
            //var moon = SatelliteCreator("Moon", earth.Id, 1.5, 20, 20, 27);
            //
            //satellites.Add(moon);

            context.SpaceObjects.Add(sun);
            context.SpaceObjects.AddRange(planets);
            //context.SpaceObjects.AddRange(satellites);
            context.SaveChanges();
        }
    }
}
