using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaExc
{
    class Dough
    {
        private static Dictionary<string, double> typeDough = new Dictionary<string, double>()
        {
            {"white", 1.5 },
            {"wholegrain", 1.0},
            {"crispy", 0.9},
            {"chewy", 1.1},
            {"homemade", 1.0}
        };
        private string firstType;
        private string secondType;
        private int weight;
        private double numCalories = 0;

        public double NumCalories
        {
            get => numCalories;
        }
        public string FirstType
        {
            get => firstType;
            set
            {
                if (!(typeDough.ContainsKey(value)))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                firstType = value;
            }
        }
        public string SecondType
        {
            get => secondType;
            set
            {
                if (!(typeDough.ContainsKey(value)))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                secondType = value;
            }
        }
        public int Weight
        {
            get => weight;
            set
            {
                if (value>200 || value < 0)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                weight = value;
            }
        }

        
        public Dough(string firstType, string secondType, int weight)
        {
            FirstType = firstType;
            SecondType = secondType;
            Weight = weight;
            numCalories += typeDough[FirstType] * typeDough[secondType] * Weight * 2;
        }

    }
}
