using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamGenerator
{
    public class Team
    {
        private string name;
        private Dictionary<string, Player> players;
        public Team(string name)
        {
            this.Name = name;
            players = new Dictionary<string, Player>();
        }
        public string Name 
        {
            get => this.name; 
            set
            {
                this.Validator(value);
                this.name = value;
            }
        }
        private void Validator(string name)
        {
            if (string.IsNullOrWhiteSpace(name)||name==string.Empty)
            {
                throw new ArgumentException("A name should not be empty.");
            }
        }

        public void AddPlayer(Player player)
        {
            this.players.Add(player.Name,player);
        }

        public void RemovePlayer(string playerName)
        {
            if (!this.players.ContainsKey(playerName))
            {
                throw new ArgumentException($"Player {playerName} is not in {this.Name} team.");
            }
            this.players.Remove(playerName);
        }
        public int GetRating()
        {
            if (players.Count==0)
            {
                return 0;
            }
            double allPlayersSkills = 0;
            foreach (var player in players)
            {
                double averagePlayerSkills = 0;
                averagePlayerSkills =1.0*(player.Value.Endurance + player.Value.Dribble + player.Value.Passing + player.Value.Shooting + player.Value.Sprint)/5;
                allPlayersSkills += Math.Round(averagePlayerSkills);
            }
            int teamRating = (int)Math.Round((double)allPlayersSkills / this.players.Count);
            return teamRating;
        }
    }
}
