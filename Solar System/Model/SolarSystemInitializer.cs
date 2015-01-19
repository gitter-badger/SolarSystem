using System;
using System.Collections.Generic;
using System.Data.Entity;
using Model.Models;

namespace Model
{
    public class SolarSystemInitializer
    {
        public void Seed(SolarSystemContext context)
        {
            var spaceObjects = new List<SpaceObject>
            {
                new SpaceObject {Id = Guid.NewGuid(), Name = "Sun"},
                new SpaceObject {Id = Guid.NewGuid(), Name = "Mercury"},
                new SpaceObject {Id = Guid.NewGuid(), Name = "Venus"},
                new SpaceObject {Id = Guid.NewGuid(), Name = "Mars"},
                new SpaceObject {Id = Guid.NewGuid(), Name = "Jupiter"},
                new SpaceObject {Id = Guid.NewGuid(), Name = "Saturn"},
                new SpaceObject {Id = Guid.NewGuid(), Name = "Uranus"},
                new SpaceObject {Id = Guid.NewGuid(), Name = "Neptune"},
                new SpaceObject {Id = Guid.NewGuid(), Name = "Earth"},
            };

            spaceObjects.ForEach(s => context.SpaceObjects.Add(s));
            context.SaveChanges();
        }
    }
}
