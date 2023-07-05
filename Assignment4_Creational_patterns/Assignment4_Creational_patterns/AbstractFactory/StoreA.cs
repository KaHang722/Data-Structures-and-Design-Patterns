using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_Creational_patterns.AbstractFactory
{
    public class StoreA : Store
    {
        public override Furniture CreateFurniture()
        {
            return new Chair();
        }

        public override Bedding CreateBedding()
        {
            return new ChairCushion();
        }
    }
}
