using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Adaptor
{
    public class WeightAppUk : WeightAdaptor
    {
        private Weight weightApp;

        public WeightAppUk(Weight weightApp)
        {
            this.weightApp = weightApp;
        }

        public double getWeight()
        {
            return convertToKg(weightApp.getWeight());
        }

        public double convertToKg(double w)
        {
            return w / 2.2;
        }
    }
}
