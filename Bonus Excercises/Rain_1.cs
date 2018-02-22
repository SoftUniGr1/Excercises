using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rain_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int regions = int.Parse(Console.ReadLine());
            double sumRain = 0;
            double density = double.Parse(Console.ReadLine());
            Dictionary<int, int> rainRegion = new Dictionary<int, int>();
            List<double> rainInTotal = new List<double>();
            if (density>0 && density <= 9)
            {
                for (int i = 0; i<regions; i++)
                {
                    int[] rainTotal = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                    rainRegion.Add(rainTotal[0], rainTotal[1]);
                }
                foreach (var rain in rainRegion)
                {
                    int intRain = rain.Key;
                    rainInTotal.Add((intRain * 1.0) / (rainRegion[rain.Key]*1.0));
                    sumRain += (intRain * 1.0) / (rainRegion[rain.Key] * 1.0);
                }
                Console.WriteLine("{0:f3}", sumRain / density);
            }
        }
    }
}
