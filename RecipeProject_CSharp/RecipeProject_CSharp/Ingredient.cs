using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeProject_CSharp
{
    public class Ingredient
    {
        public int quantity { get; set; }
        public string name { get; set; }
        public string unit { get; set; }

        public Ingredient(int quantity, string unit, string name)
        {
            this.quantity = quantity;
            this.unit = unit;
            this.name = name;
        }
        public Ingredient() { }

        public String ToString()
        {
            return quantity + " " + unit + " " + name;
        }

        public String ToSaveString()
        {
            return quantity + "," + unit + "," + name;
        }
    }
}
