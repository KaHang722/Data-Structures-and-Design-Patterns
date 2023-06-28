using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Adaptor
{
    public class WeightApp : Weight
    {
        public int weightInPounds;

        public WeightApp(int weightInPounds)
        {
            this.weightInPounds = weightInPounds;
        }

        public double getWeight()
        {
            return weightInPounds;   
        }
    }
}
