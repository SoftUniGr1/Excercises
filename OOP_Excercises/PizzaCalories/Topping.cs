using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaExc
{
    class Topping
    {
        private static Dictionary<string, double> toppingType = new Dictionary<string, double>()
        {
            {"meat", 1.2 },
            {"veggies", 0.8 },
            {"cheese", 1.1 },
            {"sauce", 0.9 }
        };
        private string type;
        private int weight;
        private double numCalories = 0;

        public string Type
        {
            get => type;
            set
            {
                if (!(toppingType.ContainsKey(value)))
                {
                    throw new ArgumentException("Cannot place " + value + " on top of your pizza.");
                }
                type = value;
            }
        }
        public int Weight
        {
            get => weight;
            set
            {
                if (value < 0 || value > 50)
                {
                    throw new ArgumentException("{0} weight should be in the range [1..50].", Type);
                }
                weight = value;
            }
        }
        public double NumCalories
        {
            get => numCalories;
        }
        public Topping(string type, int weight)
        {
            Type = type;
            Weight = weight;
            numCalories += toppingType[type] * weight * 2;
        }
    }
}
