using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phoenix_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int startingPoint = int.Parse(Console.ReadLine());
            int attack = 1;
            int point = 0;
            string command = Console.ReadLine();
            while(command != "Supernova")
            {
                string[] move = command.Split(' ');
                int movements = int.Parse(move[1]);
                
                if (move[0] == "left")
                {
                    int difference = startingPoint - movements;
                    for (int i = startingPoint - 1; i>difference +1; i--)
                    {
                        
                        if (i < 0)
                        {
                            attack++;
                            difference = i+1;
                            i = numbers.Length - 1;
                            numbers[i] = numbers[i] - attack;
                            if (numbers[i] < 0)
                            {
                                numbers[i] = 0;
                            }
                            Console.WriteLine(String.Join(" ", numbers));
                            
                        }
                        else
                        {
                            numbers[i] -= attack;
                            if (numbers[i] < 0)
                            {
                                numbers[i] = 0;
                            }
                            Console.WriteLine(String.Join(" ", numbers));
                        }
                        point = i;
                    }
                    startingPoint = point;
                    
                }
                if (move[0] == "right")
                {
                    int difference = startingPoint + movements;
                    for (int i = startingPoint; i<difference - 1; i++)
                    {
                        if (i > numbers.Length - 1)
                        {
                            attack++;
                            difference = i + 1;
                            i = 0;
                            numbers[i] = numbers[i] - attack;
                            if (numbers[i] < 0)
                            {
                                numbers[i] = 0;
                            }
                            Console.WriteLine(String.Join(" ", numbers));

                        }
                        else
                        {
                            numbers[i] -= attack;
                            if (numbers[i] < 0)
                            {
                                numbers[i] = 0;
                            }
                            Console.WriteLine(String.Join(" ", numbers));
                        }
                        point = i;
                    }
                    startingPoint = point;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
