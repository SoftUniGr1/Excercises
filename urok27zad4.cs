using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace urok27zad4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] food = Console.ReadLine().Split(' ').ToArray();
            Dictionary<string, double> foodPrice = new Dictionary<string, double>();
            double grandTotal = 0;
            Dictionary<string, int> foodAmount = new Dictionary<string, int>();
            
            int br = 1; int rb = 1;
            while (food[0] != "stocked")
            {
                
                foreach(var price in foodPrice)
                {
                    if (price.Key.Equals(food[0]))
                    {
                        foodPrice[price.Key] = double.Parse(food[1]);
                        br = 0;
                        break;
                    }
                    else
                    {
                        br++;
                    }
                }
                if (br > 0)
                {
                    foodPrice.Add(food[0], double.Parse(food[1]));
                    br = 0;
                }
                foreach(var amount in foodAmount)
                {
                    if (amount.Key.Equals(food[0]))
                    {
                        foodAmount[amount.Key] += int.Parse(food[2]);
                        rb = 0;
                        break;
                    }
                    else
                    {
                        rb++;
                    }
                }
                if (rb > 0)
                {
                    foodAmount.Add(food[0], int.Parse(food[2]));
                    rb = 0;
                }
                food = Console.ReadLine().Split(' ').ToArray();
            }
            Console.WriteLine();
            Console.WriteLine();

            foreach (var foodTotal in foodPrice)
            {
                grandTotal += (foodPrice[foodTotal.Key] * foodAmount[foodTotal.Key]);
                Console.WriteLine("{0}: ${1:0.00} * {2} = ${3:0.00}", foodTotal.Key, foodPrice[foodTotal.Key], foodAmount[foodTotal.Key], (foodPrice[foodTotal.Key] * foodAmount[foodTotal.Key]));
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine("Grand Total: ${0:0.00}", grandTotal);
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
