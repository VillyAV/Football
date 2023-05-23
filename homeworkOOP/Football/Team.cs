using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    public class Team
    {
        public Coach Coach { get; set; }
        public List<FootballPlayer> players 
        {
            get
            {
                return players;
            }
            set
            {
                if (players.Count < 11 && players.Count > 22)
                {
                    Console.WriteLine("Players must be min 11 and up to 22!");
                }
                players = value;
            }
        }
        public int AverageAgeOfPlayersInTheTeam()
        {
            int sumAge = 0;
            for (int i = 0; i < players.Count; i++)
            {
                sumAge += players[i].Age;
            }
            return sumAge / players.Count;
        }
    }
}
