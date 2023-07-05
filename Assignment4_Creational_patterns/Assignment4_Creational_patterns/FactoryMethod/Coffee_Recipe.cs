using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_Creational_patterns.FactoryMethod
{
    internal class Coffee_Recipe : Recipe
    {
        public override void AddIngredients()
        {
            Ingredients.Add(new Water());
            Ingredients.Add(new Coffee());
            Ingredients.Add(new Sugar());
        }
    }
}
