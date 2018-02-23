using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            double maxSum = 0;
            int numberOfSites = int.Parse(Console.ReadLine());
            int secKey = int.Parse(Console.ReadLine());
            int secToken = 1;
            Dictionary<string, int> visitsSite = new Dictionary<string, int>();
            Dictionary<string, double> moneySite = new Dictionary<string, double>();
            for (int i = 0; i < numberOfSites; i++) {
                string[] specSite = Console.ReadLine().Split(' ').ToArray();
                visitsSite.Add(specSite[0], int.Parse(specSite[1]));
                moneySite.Add(specSite[0], double.Parse(specSite[2]));
            }
            foreach(var site in visitsSite)
            {
                Console.WriteLine("{0}", site.Key);
                maxSum += (visitsSite[site.Key] * moneySite[site.Key]);
                secToken = secToken * secKey;
            }
            Console.WriteLine("Total loss: {0:f20}", maxSum);
            Console.WriteLine("Security token: {0}", secToken);
        }
    }
}
