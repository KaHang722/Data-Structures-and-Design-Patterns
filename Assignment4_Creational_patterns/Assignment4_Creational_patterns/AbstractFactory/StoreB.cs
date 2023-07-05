using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_Creational_patterns.AbstractFactory
{
    public class StoreB : Store
    {
        public override Furniture CreateFurniture()
        {
            return new BedFrame();
        }

        public override Bedding CreateBedding()
        {
            return new Pillow();
        }
    }
}
