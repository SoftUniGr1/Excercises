using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace urok26zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int coloumns = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, coloumns];
            int maxSum = int.MinValue;
            int[,] square = new int[2, 2];
            for (int row = 0; row<rows; row++)
            {
                int[] rowArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int coloumn = 0; coloumn<coloumns; coloumn++)
                {
                    matrix[row, coloumn] = rowArray[coloumn];
                }
            }
            for (int row = 0; row<rows-1; row++)
            {
                for (int coloumn = 0; coloumn<coloumns-1; coloumn++)
                {
                    if (matrix[row, coloumn] + matrix[row + 1, coloumn] + matrix[row, coloumn + 1] + matrix[row + 1, coloumn + 1] > maxSum)
                    {
                        maxSum = matrix[row, coloumn] + matrix[row + 1, coloumn] + matrix[row, coloumn + 1] + matrix[row + 1, coloumn + 1];
                        square[0, 0] = matrix[row, coloumn];
                        square[1, 0] = matrix[row + 1, coloumn];
                        square[0, 1] = matrix[row, coloumn + 1];
                        square[1, 1] = matrix[row + 1, coloumn + 1];
                    } 
                }
            }

            for (int row = 0; row<2; row++)
            {
                for (int coloumn = 0; coloumn<2; coloumn++)
                {
                    Console.Write(square[row, coloumn] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
