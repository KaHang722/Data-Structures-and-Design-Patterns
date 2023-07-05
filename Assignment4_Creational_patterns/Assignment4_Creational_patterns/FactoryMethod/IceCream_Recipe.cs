using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_Creational_patterns.FactoryMethod
{
    internal class IceCream_Recipe : Recipe
    {
        public override void AddIngredients()
        {
            Ingredients.Add(new Milk());
            Ingredients.Add(new Flavour());
            Ingredients.Add(new Chocolate_Chip());
        }
    }
}
