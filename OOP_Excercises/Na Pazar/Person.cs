using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urok9_ZadPazar
{
    class Person
    {
        private string name;
        private double amount;

        public Person(string name, double amount)
        {
            this.name = name;
            this.amount = amount;
        }

        public string Name
        {
            get => name;
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                name = value;
            }
        }
        public double Amount
        {
            get => amount;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                amount = value;
            }
        }
    }
}
