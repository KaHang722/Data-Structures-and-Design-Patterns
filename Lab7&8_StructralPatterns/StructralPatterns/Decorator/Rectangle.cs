using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Decorator
{
    public class Rectangle : Shape
    {
        public void Draw()
        {
            Console.WriteLine("Draw a rectangle");
        }
    }
}
