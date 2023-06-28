using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Decorator
{
    public abstract class ShapeDecorator : Shape
    {
        public Shape shape;

        public ShapeDecorator(Shape shape)
        {
            this.shape = shape;
        }

        public virtual void Draw()
        {
            shape.Draw();
        }
    }
}
