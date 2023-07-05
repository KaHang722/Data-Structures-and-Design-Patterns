using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_Creational_patterns.AbstractFactory
{
    public abstract class Store
    {
        public abstract Furniture CreateFurniture();
        public abstract Bedding CreateBedding();
    }
}
