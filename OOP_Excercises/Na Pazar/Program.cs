using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urok9_ZadPazar
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] people = Console.ReadLine().Split(' ',';','=').ToArray();
            string[] products = Console.ReadLine().Split(' ', ';', '=').ToArray();
            Dictionary<string, double> peopleInfo = new Dictionary<string, double>();
            Dictionary<string, double> productInfo = new Dictionary<string, double>();
            Dictionary<string, List<string>> purchases = new Dictionary<string, List<string>>();
            for (int i = 0; i<people.Length; i+=2)
            {
                string nameOfPerson = people[i];
                double moneyOfPerson = double.Parse(people[i + 1]);
                if (peopleInfo.ContainsKey(nameOfPerson))
                {
                    peopleInfo[nameOfPerson] += moneyOfPerson;
                }
                else
                {
                    peopleInfo.Add(nameOfPerson, moneyOfPerson);
                }

                try
                {
                    Person person = new Person(nameOfPerson, moneyOfPerson);
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            for (int i = 0; i < people.Length; i += 2)
            {
                string nameOfProduct = products[i];
                double moneyOfProduct = double.Parse(products[i + 1]);
                if (productInfo.ContainsKey(nameOfProduct))
                {
                    productInfo[nameOfProduct] += moneyOfProduct;
                }
                else
                {
                    productInfo.Add(nameOfProduct, moneyOfProduct);
                }

                try
                {
                    Product product = new Product(nameOfProduct, moneyOfProduct);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }

            string command = Console.ReadLine();
            while (command != "END")
            {
                string[] newCommand = command.Split(' ');
                string buyer = newCommand[0];
                string productBought = newCommand[1];

                if (peopleInfo.ContainsKey(buyer) && productInfo.ContainsKey(productBought))
                {
                    if (peopleInfo[buyer] >= productInfo[productBought])
                    {
                        Console.WriteLine("{0} bought {1}", buyer, productBought);
                        peopleInfo[buyer] -= productInfo[productBought];
                        if (purchases.ContainsKey(buyer))
                        {
                            purchases[buyer].Add(productBought);
                        }
                        else
                        {
                            purchases.Add(buyer, new List<string>());
                            purchases[buyer].Add(productBought);
                        }
                    }
                    else
                    {
                        Console.WriteLine("{0} can't afford {1}", buyer, productBought);
                    }
                }
                command = Console.ReadLine();
            }

            foreach (var key in purchases.Keys)
            {
                if (purchases[key].Count == 0)
                {
                    Console.WriteLine("{0} - Nothing bought", key);
                }
                else
                {
                    Console.Write("{0} - ", key);
                    Console.WriteLine(String.Join(", ", purchases[key]));
                }
                
            }
        }
    }
}
