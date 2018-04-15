using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_1
{
    class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private double salary;

        public string FirstName
        {
            get => firstName;
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("First name cannot be empty");
                }
                firstName = value;
            }
        }
        public string LastName
        {
            get => lastName;
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Last name cannot be empty");
                }
                lastName = value;
            }
        }
        public int Age
        {
            get => age;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age cannot be negative");
                }
                age = value;
            }
        }
        public double Salary
        {
            get => salary;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Salary cannot be negative");
                }
                salary = value;
            }
        }
        public Person(string firstName, string lastName, int age, double salary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.salary = salary;
        }
    }
}
