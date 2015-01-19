using System.Data.Entity;
using Model.Models;

namespace Model
{
    public class SolarSystemContext : DbContext
    {
        public SolarSystemContext() : base("SolarSystemContext") { }

        public DbSet<SpaceObject> SpaceObjects { get; set; }
    }
}
