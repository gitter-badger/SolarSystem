using System;
using System.Collections.Generic;
using Model.Models;

namespace Solar_System.Models
{
    public class SpaceObjectViewModel
    {
        public Guid Id { get; set; }
        public Guid? SpaceObjectId { get; set; }
        public String Name { get; set; }
        public String SymbolUrl { get; set; }
        public double Radius { get; set; }
        public double OrbitalPeriod { get; set; }
        public bool IsRetrograd { get; set; }
        public SpaceObjectType Type { get; set; }
        public bool IsCenter { get; set; }
        public OrbitViewModel Orbit { get; set; }

        public virtual ICollection<SpaceObject> Satellites { get; set; }
        public virtual SpaceObject Primary { get; set; }

        public SizeType Size
        {
            get
            {
                SizeType result;

                if (Radius <= 5)
                {
                    result = SizeType.Small;
                }
                else if (Radius >= 20)
                {
                    result = SizeType.Large;
                }
                else
                {
                    result = SizeType.Medium;
                }

                return result;
            }
        }
    }
}