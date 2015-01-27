namespace Solar_System.Models
{
    public class OrbitViewModel
    {
        public int Aphelion { get; set; }
        public int Perihelion { get; set; }
        public int SemiMajorAxis { get; set; }
        public int SemiMinorAxis { get; set; }
        public double Eccentricity { get; set; }
        public double FocusParameter { get; set; }
        public int MajorAxis { get { return SemiMajorAxis * 2; } }
        public int MinorAxis { get { return SemiMinorAxis * 2; } }
    }
}