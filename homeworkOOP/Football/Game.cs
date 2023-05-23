using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    public class Game
    {
        public Team Team1 
        {
            get
            {
                return Team1;
            }
            set
            {
                if (Team1.players.Count < 11 && Team1.players.Count > 11)
                {
                    Console.WriteLine("Players must be 11!");
                }
                Team1 = value;
            }
        }
        public Team Team2 
        {
            get
            {
                return Team2;
            }
            set
            {
                if (Team2.players.Count < 11 && Team2.players.Count > 11)
                {
                    Console.WriteLine("Players must be 11!");
                }
                Team2 = value;
            }
        }
        public Referee Referee { get; set; }
        public Referee AssistantReferee1 { get; set; }
        public Referee AssistantReferee2 { get; set; }
        private List<string> goalsTeam1;
        private List<string> goalsTeam2;
        public void Goals(int minute, string player)
        {
            goalsTeam1 = new List<string>();
            goalsTeam2 = new List<string>();
            for (int i = 0; i < Team1.players.Count; i++)
            {
                if (player == Team1.players[i].Name)
                {
                    goalsTeam1.Add($"{minute} - {player}");
                }
            }
            for (int i = 0; i < Team2.players.Count; i++)
            {
                if (player == Team2.players[i].Name)
                {
                    goalsTeam2.Add($"{minute} - {player}");
                }
            }
        }
        public string GameResult()
        {
            return $"{goalsTeam1.Count} - {goalsTeam2.Count}";
        }
        public void Winner()
        {
            if (goalsTeam1.Count > goalsTeam2.Count)
            {
                Console.WriteLine("The winner is Team1!");
            }
            if (goalsTeam1.Count < goalsTeam2.Count)
            {
                Console.WriteLine("The winner is Team2!");
            }
        }
    }
}
