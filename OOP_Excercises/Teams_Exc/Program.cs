using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfPeople = int.Parse(Console.ReadLine());
            Team hello = new Team();
            for (int i = 0; i < numOfPeople; i++) {
                string[] someoneInfo = Console.ReadLine().Split(' ').ToArray();
                string firstName = someoneInfo[0];
                string lastName = someoneInfo[1];
                int age = int.Parse(someoneInfo[2]);
                double salary = double.Parse(someoneInfo[3]);
                Person someone = new Person(firstName, lastName, age, salary);
                hello = new Team(firstName);
                try
                {
                    someone = new Person(firstName, lastName, age, salary);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                hello.AddPlayer(someone);
            }
            Console.WriteLine("First team has {0} players.", hello.FirstTeam.Count);
            Console.WriteLine("Reserve team has {0} players.", hello.ReserveTeam.Count);
        }
    }
}
