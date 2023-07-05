using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_Creational_patterns.FactoryMethod
{
    public abstract class Recipe
    {
        private List<Ingredient> _ingredients = new List<Ingredient>();

        public Recipe()
        {
            this.AddIngredients();
        }

        public List<Ingredient> Ingredients
        {
            get { return _ingredients; }
        }

        //Factory Method
        public abstract void AddIngredients();
    }
}
