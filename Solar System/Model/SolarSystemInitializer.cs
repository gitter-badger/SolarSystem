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
                 Radius = 100,
                 Type = SpaceObjectType.Star
             };

            var planets = new List<SpaceObject>();

            var mercury = PlanetCreator("Mercury", sun.Id, 5, 10, 10, 88);
            var venus = PlanetCreator("Venus", sun.Id, 12.1, 60, 60, 224);
            var earth = PlanetCreator("Earth", sun.Id, 13.2, 110, 110, 365);
            var mars = PlanetCreator("Mars", sun.Id, 6.8, 160, 160, 687);
            var jupiter = PlanetCreator("Jupiter", sun.Id, 41.1, 300, 300, 4332);
            var saturn = PlanetCreator("Saturn", sun.Id, 34.6, 400, 400, 10759);
            var uranus = PlanetCreator("Uranus", sun.Id, 20, 700, 700, 30685);
            var neptune = PlanetCreator("Neptune", sun.Id, 14.2, 900, 900, 60190);

            planets.AddRange(new List<SpaceObject>
            {
                mercury,venus,earth,mars,jupiter,saturn,uranus,neptune
            });

            context.SpaceObjects.Add(sun);
            context.SpaceObjects.AddRange(planets);
            context.SaveChanges();
        }

        private static SpaceObject PlanetCreator(String name, Guid? primaryId, double radius, int aphelion, int perihelion, double orbitalPeriod)
        {
            var planet = SpaceObjectCreator(name, primaryId, radius);
            planet.Aphelion = aphelion;
            planet.Perihelion = perihelion;
            planet.OrbitalPeriod = orbitalPeriod;
            planet.Type = SpaceObjectType.Planet;

            return planet;
        }

        private static SpaceObject SpaceObjectCreator(String name, Guid? primaryId, double radius, bool isCenter = false)
        {
            var spaceObject = new SpaceObject()
            {
                Id = Guid.NewGuid(),
                Name = name,
                SpaceObjectId = primaryId,
                Radius = radius,
                IsCenter = isCenter
            };

            return spaceObject;
        }
    }
}
