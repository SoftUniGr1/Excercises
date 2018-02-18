using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace urok25zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int coloumns = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, coloumns];
            int[] minSum = new int[coloumns];
            int min = int.MaxValue;
            for (int row = 0; row < rows; row++)
            {

                int[] rowArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int coloumn = 0; coloumn < coloumns; coloumn++)
                {
                    matrix[row, coloumn] = rowArray[coloumn];
                    
                }
               

            }
            for (int coloumn = 0; coloumn<coloumns; coloumn++)
            {
                for (int row = 0; row<rows; row++)
                {
                    if (matrix[row, coloumn] < min)
                    {
                        min = matrix[row, coloumn];
                        
                    }
                    
                }
                minSum[coloumn] = min;
                min = int.MaxValue;
            }
            for (int row = 0; row<rows; row++)
            {
                for (int coloumn = 0; coloumn<coloumns; coloumn++)
                {
                    Console.Write(matrix[row, coloumn] + " ");
                    
                }
                Console.WriteLine();
            }

            for (int coloumn = 0; coloumn<coloumns; coloumn++)
            {
                Console.Write(minSum[coloumn]+" ");
            }
            Console.WriteLine();

        }
    }
}
