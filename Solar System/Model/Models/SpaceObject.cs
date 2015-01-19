using System;
using System.Collections.Generic;

namespace Model.Models
{
    public class SpaceObject
    {
        public Guid Id { get; set; }
        public Guid PrimaryId { get; set; }
        public String Name { get; set; }
        public int Radius { get; set; }
        public double OrbitalPeriod { get; set; }
        public int Aphelion { get; set; }
        public int Perihelion { get; set; }
        public SpaceObjectType Type { get; set; }

        public virtual ICollection<SpaceObject> Satellites { get; set; } 
    }
}
