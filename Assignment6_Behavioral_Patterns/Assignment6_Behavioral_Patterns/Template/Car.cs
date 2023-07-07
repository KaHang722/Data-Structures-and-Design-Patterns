using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6_Behavioral_Patterns.Template
{
    public class Car : Manufacture
    {
        public override void AssembleExterior()
        {
            Console.WriteLine("Assembling exteriors of a car");
        }

        public override void PrepareInteriors()
        {
            Console.WriteLine("Preparing interiors of the car");
        }

        public override void Paint()
        {
            Console.WriteLine("Painting the car");
        }

        public override void Polish()
        {
            Console.WriteLine("Polishing the car");
        }
    }
}
