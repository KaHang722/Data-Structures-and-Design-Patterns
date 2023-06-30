using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Template
{
    public class Bagel : Bake
    {
        public override void BakeIt()
        {
            Console.WriteLine("Baking Bagel");
        }

        public override void CoolDown()
        {
            Console.WriteLine("Let Bagels is cool down");
        }

        public override void MixIngredients()
        {
            Console.WriteLine("Mixing Ingredients for bagels");
        }

        public override void Pack()
        {
            Console.WriteLine("Special Packaging " + GetType().Name);
        }
    }
}
