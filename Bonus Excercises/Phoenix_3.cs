using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phoenix_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] array = input.ToCharArray();
            char[] reversedArray = new char[array.Length];
            int position = 0;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                reversedArray[position] = array[i];
                position++;
            }
            bool rezult = true;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == ' ' || array[i] == '_')
                {
                    rezult = false;
                }
                if (array[i] != reversedArray[i])
                {
                    rezult = false;
                }
            }
            if (rezult == true)
            {
                Console.WriteLine("True");

            }
            else
                Console.WriteLine("False");
        }
    }
}
