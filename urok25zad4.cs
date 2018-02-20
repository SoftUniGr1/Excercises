using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace urok25zad4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lotterySize = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rows = lotterySize[0];
            int cols = lotterySize[1];
            int[,] lottery = new int[rows, cols];
            int mainDiag = 0;
            int secondDiag = 0;
            int sumAboveMain = 0;
            int sumBelowMain = 0;
            int br = 0;
            int evenMain = 0;
            int sumCol = 0;
            int sumRow = 0;
            string answer = "";
            for (int row = 0; row < rows; row++)
            {
                string[] lotteryArray = Console.ReadLine().Split(' ').ToArray();
                for (int col = 0; col < cols; col++)
                {
                    lottery[row, col] = int.Parse(lotteryArray[col]);
                }
            }
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (row == col)
                    {
                        mainDiag += lottery[row, col];
                        if (lottery[row, col] % 2 == 0)
                        {
                            evenMain += lottery[row, col];
                        }
                    }
                    if (row + col == rows - 1)
                    {
                        secondDiag += lottery[row, col];
                    }

                }
            }
            if (rows >= cols)
            {
                for (int row = 0; row < cols; row++)
                {
                    for (int col = row + 1; col < cols; col++)
                    {
                        sumAboveMain += lottery[row, col];
                    }
                }
                for (int row = 1; row < rows; row++)
                {
                    for (int col = 0; col < row; col++)
                    {
                        sumBelowMain += lottery[row, col];
                    }
                }
            }
            else
            {
                for (int row = 0; row < rows; row++)
                {
                    for (int col = row + 1; col < rows; col++)
                    {
                        sumAboveMain += lottery[row, col];
                    }
                }
                for (int row = 1; row < rows; row++)
                {
                    for (int col = 0; col < row; col++)
                    {
                        sumBelowMain += lottery[row, col];
                    }
                }
            }
            if (sumAboveMain % 2 == 0)
            {
                br++;
            }
            if (sumBelowMain % 2 == 1)
            {
                br++;
            }
            if (mainDiag == secondDiag)
            {
                br += 2;
            }
            if (br % 4 == 0)
            {
                Console.WriteLine("YES");
                answer = "yes";
            }
            else
            {
                Console.WriteLine("NO");
                answer = "no";

            }
            if (answer == "yes")
            {
                for (int col = 0; col < cols; col++)
                {
                    if (lottery[0, col] % 2 == 0)
                    {
                        sumCol += lottery[0, col];
                    }
                    if (lottery[rows - 1, col] % 2 == 0)
                    {
                        sumCol += lottery[rows - 1, col];
                    }
                }
                for (int row = 0; row < rows; row++)
                {
                    if (lottery[row, 0] % 2 == 1)
                    {
                        sumRow += lottery[row, 0];
                    }
                    if (lottery[row, cols - 1] % 2 == 1)
                    {
                        sumRow += lottery[row, cols - 1];
                    }
                }
                Console.WriteLine("The amount of money won is: {0:0.00}", (evenMain + sumBelowMain + sumRow + sumCol) / 4.0);
            }

        }
    }
}

