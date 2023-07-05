using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_Creational_patterns
{
    public class Employee : Prototype
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public override Prototype getClone()
        {
            return MemberwiseClone() as Prototype;
        }
    }
}
