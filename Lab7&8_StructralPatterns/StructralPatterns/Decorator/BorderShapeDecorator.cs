using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Decorator
{
    public class BorderShapeDecorator : ShapeDecorator
    {
        public BorderShapeDecorator(Shape shape) : base(shape)
            { }

        public override void Draw()
        {
            base.Draw();
            Console.WriteLine("Create a dotter border around the shape that was passed.");
        }
    }
}
