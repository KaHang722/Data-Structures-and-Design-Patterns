using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Composite
{
    public class Manager : Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Manager(int iD, string name)
        {
            ID = iD;
            Name = name;
        }
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine(ID + " " + Name);
        }
    }
}
