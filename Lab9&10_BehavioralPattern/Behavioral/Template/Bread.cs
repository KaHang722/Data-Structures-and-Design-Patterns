using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Template
{
    public class Bread : Bake
    {
        public override void BakeIt()
        {
            Console.WriteLine("Baking Bread");
        }

        public override void CoolDown()
        {
            Console.WriteLine("Bread is cooling down");
        }

        public override void MixIngredients()
        {
            Console.WriteLine("Mixing Ingredients for Bread");
        }
    }
}
