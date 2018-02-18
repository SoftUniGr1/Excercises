using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace urok26zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = 3;
            int cols = 3;
            string[,] tic = new string[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                string[] rowArray = Console.ReadLine().Split(' ').ToArray();
                for (int col = 0; col < cols; col++)
                {
                    tic[row, col] = rowArray[col];
                    if( tic[row,col]!="X" && tic[row,col]!="O" && tic[row, col] != "-")
                    {
                        Console.WriteLine("Error!");
                        col = int.MaxValue;
                        row = int.MaxValue;
                        break;
                    }
                }
            }
            //x x x
            if (tic[0, 0] == tic [0, 1] && tic[0, 1] == tic[0, 2])
            {
                if (tic[0, 0] == "X")
                {
                    Console.WriteLine("The winner is: X");
                }
                else if (tic[0, 0] == "O")
                {
                    Console.WriteLine("The winner is: O");
                }
            }
            //x
            //  x
            //    x
            if(tic[0, 0] == tic[1, 1] && tic[1, 1] == tic[2, 2])
            {
                if (tic[0, 0] == "X")
                {
                    Console.WriteLine("The winner is: X");
                }
                else if (tic[0, 0] == "O")
                {
                    Console.WriteLine("The winner is: O");
                }
            }
            //  x
            //  x
            //  x
            if (tic[1, 0] == tic[1, 1] && tic[1, 1] == tic[1, 2])
            {
                if (tic[1, 0] == "X")
                {
                    Console.WriteLine("The winner is: X");
                }
                else if (tic[1, 0] == "O")
                {
                    Console.WriteLine("The winner is: O");
                }
            }
            //    x
            //    x
            //    x
            if (tic[2, 0] == tic[2, 1] && tic[2, 1] == tic[2, 2])
            {
                if (tic[2, 0] == "X")
                {
                    Console.WriteLine("The winner is: X");
                }
                else if (tic[2, 0] == "O")
                {
                    Console.WriteLine("The winner is: O");
                }
            }
            //    x
            //  x
            //x
            if (tic[0, 2] == tic[1, 1] && tic[0, 1] == tic[2, 0])
            {
                if (tic[0, 2] == "X")
                {
                    Console.WriteLine("The winner is: X");
                }
                else if (tic[0, 2] == "O")
                {
                    Console.WriteLine("The winner is: O");
                }
            }
            //x
            //x
            //x
            if (tic[0, 0] == tic[1, 0] && tic[1, 0] == tic[2, 0])
            {
                if (tic[0, 0] == "X")
                {
                    Console.WriteLine("The winner is: X");
                }
                else if (tic[0, 0] == "O")
                {
                    Console.WriteLine("The winner is: O");
                }
            }
            //
            //x x x
            //
            if (tic[1, 0] == tic[1, 1] && tic[1, 1] == tic[1, 2])
            {
                if (tic[0, 0] == "X")
                {
                    Console.WriteLine("The winner is: X");
                }
                else if (tic[0, 0] == "O")
                {
                    Console.WriteLine("The winner is: O");
                }
            }
            //
            //
            //x x x
            if (tic[0, 0] == tic[0, 1] && tic[0, 1] == tic[0, 2])
            {
                if (tic[0, 0] == "X")
                {
                    Console.WriteLine("The winner is: X");
                }
                else if (tic[0, 0] == "O")
                {
                    Console.WriteLine("The winner is: O");
                }
            }

        }
    }
}
