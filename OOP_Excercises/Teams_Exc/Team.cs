using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_1
{
    class Team
    {
        private string name;
        private static List<Person> firstTeam = new List<Person>();
        public static int firstTeamCount = 0;
        private static List<Person> reserveTeam = new List<Person>();
        public static int reserveTeamCount = 0;
        public Team()
        {

        }
        public Team (string name)
        {
            this.name = name;
        }

        public IReadOnlyCollection<Person> FirstTeam
        {
            get => firstTeam.AsReadOnly();
        }
        public IReadOnlyCollection<Person> ReserveTeam
        {
            get => reserveTeam.AsReadOnly();
        }

        public void AddPlayer(Person player)
        {
            if (player.Age < 40)
            {
                firstTeam.Add(player);
                firstTeamCount++;
            }
            else
            {
                reserveTeam.Add(player);
                reserveTeamCount++;
            }
        }


    }
}
