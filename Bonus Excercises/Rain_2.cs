using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rain1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            
            int lastIndex = numbers[numbers.Count-1];
            numbers.RemoveAt(numbers.Count - 1);
            List<int> savedNumbers = new List<int>(numbers);
            for (int i = 0; i<numbers.Count; i++)
            {
                savedNumbers[i] = numbers[i];
            }
            for (int j = 0; j > -1; j++)
            {
                for (int i = 0; i< numbers.Count; i++)
                {
                    numbers[i]--;
                }
                for (int i = 0; i < numbers.Count; i++)
                {
                    
                    if (numbers[i] == 0 && i!=lastIndex)
                    {
                        numbers[i] = savedNumbers[i];
                    }

                    if (i == lastIndex && numbers[i] == 0)
                    {
                        Console.WriteLine(String.Join(" ", numbers));
                        Console.WriteLine(j);
                        j = -2;
                        break;
                    }
                }
                if (j == -2)
                {
                    break;
                }
                lastIndex = int.Parse(Console.ReadLine());
            }
        }
    }
}
