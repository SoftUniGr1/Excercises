using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaExc
{
    class Program
    {
        static void Main(string[] args)
        {
            string pizzaName = "";
            double totalCalories = 0;
            int numOfToppings = 0;
            int failure = 0;
            string something = Console.ReadLine();
            while (something != "END")
            {
                string[] newCommand = something.Split(' ');
                if (failure == 0)
                {
                    if (newCommand[0] == "Dough")
                    {
                        Dough pizzaDough;
                        try
                        {
                            pizzaDough = new Dough(newCommand[1].ToLower(), newCommand[2].ToLower(), int.Parse(newCommand[3]));
                            totalCalories += pizzaDough.NumCalories;
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                            failure++;
                        }
                        

                    }
                    if (newCommand[0] == "Topping")
                    {
                        numOfToppings--;
                        Topping pizzaTopping;
                        try
                        {
                            pizzaTopping = new Topping(newCommand[1].ToLower(), int.Parse(newCommand[2]));
                            if (numOfToppings >= 0)
                            {
                                totalCalories += pizzaTopping.NumCalories;
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                            failure++;
                        }
                        
                    }
                    if (newCommand[0] == "Pizza")
                    {
                        Pizza pizza;
                        try
                        {
                            pizza = new Pizza(newCommand[1].ToLower(), int.Parse(newCommand[2]));
                            numOfToppings = int.Parse(newCommand[2]);
                            pizzaName = newCommand[1];
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                            failure++;
                        }
                        
                    }
                }
                something = Console.ReadLine();
            }
            if (failure == 0)
            {
                Console.WriteLine("{0} - {1:0.00} calories.", pizzaName, totalCalories);
            }
        }
    }
}
