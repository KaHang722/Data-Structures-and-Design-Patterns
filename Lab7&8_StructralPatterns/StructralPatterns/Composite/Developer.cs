using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Composite
{
    public class Developer : Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Developer(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine(Id + " " + Name);
        }
    }
}
