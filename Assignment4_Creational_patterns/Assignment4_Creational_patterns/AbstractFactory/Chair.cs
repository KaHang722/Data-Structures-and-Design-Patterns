using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_Creational_patterns.AbstractFactory
{
    public class Chair : Furniture
    {
        public override void CompareCategory(Bedding b)
        {
            Console.WriteLine(this.GetType().Name + " (Furniture) is not in the same category with " + b.GetType().Name +" (Bedding).");
        }
    }
}
