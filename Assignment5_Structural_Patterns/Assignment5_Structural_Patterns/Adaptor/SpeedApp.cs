using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_Structural_Patterns.Adaptor
{
    public class SpeedApp : Speed
    {
        public int speedInMiles;

        public SpeedApp(int speedInKM)
        {
            this.speedInMiles = speedInKM;
        }

        public double getSpeed()
        {
            return speedInMiles;
        }
    }
}
