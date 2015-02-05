namespace Solar_System.Models
{
    public class OrbitViewModel
    {
        public double PrimaryDiameter { get; set; }
        public double Aphelion { get; set; }
        public double Perihelion { get; set; }
        public double SemiMajorAxis { get; set; }
        public double SemiMinorAxis { get; set; }
        public double Eccentricity { get; set; }
        public double FocusParameter { get; set; }
        public double MajorAxis { get { return SemiMajorAxis * 2; } }
        public double MinorAxis { get { return SemiMinorAxis * 2; } }
    }
}