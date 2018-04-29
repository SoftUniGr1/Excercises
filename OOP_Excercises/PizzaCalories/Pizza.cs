using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaExc
{
    class Pizza
    {
        private string name;
        private int portions;

        public string Name
        {
            get => name;
            set
            {
                if (value.Length<=0 || value.Length >= 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 characters.");
                }
                name = value;
            }
        }
        public int Portions
        {
            get => portions;
            set
            {
                if (value >10 || value < 0)
                {
                    throw new ArgumentException("Number of toppings should be in range [0..10].");
                }
                portions = value;
            }
        }
        public Pizza(string name, int portions)
        {
            Name = name;
            Portions = portions;
        }
    }
}
