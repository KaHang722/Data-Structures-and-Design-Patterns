using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6_Behavioral_Patterns.Template
{
    public class Truck : Manufacture
    {
        public override void AssembleExterior()
        {
            Console.WriteLine("Assembling exteriors of a truck");
        }

        public override void PrepareInteriors()
        {
            Console.WriteLine("Preparing interiors of the truck");
        }

        public override void Paint()
        {
            Console.WriteLine("Painting the truck");
        }

        public override void Polish()
        {
            Console.WriteLine("Polishing the truck");
        }

        public override void dispatch()
        {
            Console.WriteLine("Dispatching " + GetType().Name + " by using expedited shipping");
        }

    }
}
