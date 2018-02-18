using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace urok27zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> goods = new Dictionary<string, int>();
            int amount = 0;
            string food = Console.ReadLine();
            int i = 0;
            while (!food.Equals("stop"))
            {
                if (i % 2 == 0)
                {
                    amount = int.Parse(Console.ReadLine());
                    goods.Add(food, amount);
                    i += 2;
                }
                else
                {
                    i++;
                }
                food = Console.ReadLine();
            }
            foreach (var good in goods)
            {
                Console.WriteLine("{0} --> {1}", good.Key, good.Value);
            }
        }
    }
}
