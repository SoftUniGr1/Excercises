using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phoenix_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double[] sum = new double[number];
            for (int i = 0; i<number; i++)
            {
                int bodyLength = int.Parse(Console.ReadLine());
                double bodyWidth = double.Parse(Console.ReadLine());
                int wingLength = int.Parse(Console.ReadLine());
                sum[i] = (bodyLength * bodyLength) * (bodyWidth + (2 * wingLength));
            }
            for (int i = 0; i<number; i++)
            {
                Console.WriteLine(sum[i]);
            }
        }
    }
}
