using Model.Models;

namespace Solar_System.Models
{
    public class SpaceObjectViewModel : SpaceObject
    {
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