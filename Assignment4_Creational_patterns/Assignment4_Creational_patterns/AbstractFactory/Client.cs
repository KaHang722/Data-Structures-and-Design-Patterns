using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_Creational_patterns.AbstractFactory
{
    public class Client
    {
        private Furniture f;
        private Bedding b;
        public Client(Store s)
        {
            f = s.CreateFurniture();
            b = s.CreateBedding();
        }

        public void Compare()
        {
            f.CompareCategory(b);
        }


    }
}
