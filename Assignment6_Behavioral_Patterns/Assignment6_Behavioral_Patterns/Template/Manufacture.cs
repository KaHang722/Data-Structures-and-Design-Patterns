using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6_Behavioral_Patterns.Template
{
    public abstract class Manufacture
    {
        public abstract void AssembleExterior();
        public abstract void PrepareInteriors();
        public abstract void Paint();
        public abstract void Polish();

        public virtual void dispatch()
        {
            Console.WriteLine("Dispatching " + GetType().Name + " by using standard shipping");
        }

        public void ManufactureProduct()
        {
            AssembleExterior();
            PrepareInteriors();
            Paint();
            Polish();
            dispatch();
        }
    }
}
