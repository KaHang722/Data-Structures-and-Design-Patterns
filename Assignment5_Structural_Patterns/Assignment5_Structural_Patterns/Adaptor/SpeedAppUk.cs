using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_Structural_Patterns.Adaptor
{
    public class SpeedAppUk : SpeedAdaptor
    {
        private Speed speedApp;

        public SpeedAppUk(Speed speedApp)
        {
            this.speedApp = speedApp;
        }

        public double getSpeed()
        {
            return convertToKm(speedApp.getSpeed());
        }

        public double convertToKm(double s)
        {
            return s * 1.609344;
        }
    }
}
