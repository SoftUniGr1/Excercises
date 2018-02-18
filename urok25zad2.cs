using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace urok25zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            double br = 0; double count = 0;
            int[] average = new int[rows];
            int[] totalCount = new int[rows];
            int coloumns = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, coloumns];
            for (int row = 0; row<rows; row++)
            {
                for (int coloumn = 0; coloumn < coloumns; coloumn++)
                {
                    matrix[row, coloumn] = int.Parse(Console.ReadLine());
                    br += matrix[row, coloumn];
                    count++;
                }
                totalCount[row] = (int)count;
                average[row] = (int)br;
                count = 0;
                br = 0;
            }
            for (int row = 0; row < rows; row++)
            {
                for (int coloumn = 0; coloumn < coloumns; coloumn++)
                {
                    Console.Write("         {0}", matrix[row,coloumn]);
                }
                Console.WriteLine();
                Console.WriteLine("       {0:0.00}", average[row] / totalCount[row]);
            }

        }
    }
}
