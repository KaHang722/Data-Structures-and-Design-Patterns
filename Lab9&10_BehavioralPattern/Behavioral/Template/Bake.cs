using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Template
{
    public abstract class Bake
    {
        public abstract void MixIngredients();
        public abstract void BakeIt();
        public abstract void CoolDown();

        public virtual void Pack()
        {
            Console.WriteLine("Packing " + GetType().Name);
        }

        //Template method

        public void BakeProduct()
        {
            MixIngredients();
            BakeIt();
            CoolDown();
            Pack();
        }
    }
}
