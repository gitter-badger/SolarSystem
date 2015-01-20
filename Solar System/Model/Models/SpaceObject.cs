using System;
using System.Collections.Generic;

namespace Model.Models
{
    public class SpaceObject
    {
        public Guid Id { get; set; }
        public Guid? SpaceObjectId { get; set; }
        public String Name { get; set; }
        public double Radius { get; set; }
        public double OrbitalPeriod { get; set; }
        public int Aphelion { get; set; }
        public int Perihelion { get; set; }
        public SpaceObjectType Type { get; set; }
        public bool IsCenter { get; set; }

        public virtual ICollection<SpaceObject> Satellites { get; set; }
        public virtual SpaceObject Primary { get; set; }
    }
}
