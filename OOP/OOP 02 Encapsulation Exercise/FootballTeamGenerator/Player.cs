using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamGenerator
{
    public class Player
    {
        private string name;
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;
        public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
        {
            this.Name = name;
            this.Endurance = endurance;
            this.Sprint = sprint;
            this.Dribble = dribble;
            this.Passing = passing;
            this.Shooting = shooting;
        }
        public string Name
        {
            get => this.name;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value == string.Empty)
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                this.name = value;
            }
        }
        public int Endurance
        {
            get => this.endurance;
            set
            {
                if (IsInRange(value, "Endurance"))
                {
                    this.endurance = value;
                }
            }
        }
        public int Sprint
        {
            get => this.sprint;
            set
            {
                if (IsInRange(value, "Sprint"))
                {
                    this.sprint = value;
                }
            }
        }
        public int Dribble
        {
            get => this.dribble;
            set
            {
                if (IsInRange(value, "Dribble"))
                {
                    this.dribble = value;
                }
            }
        }
        public int Passing
        {
            get => this.passing;
            set
            {
                if (IsInRange(value, "Passing"))
                {
                    this.passing = value;
                }
            }
        }
        public int Shooting
        {
            get => this.shooting;
            set
            {
                if (IsInRange(value, "Shooting"))
                {
                    this.shooting = value;
                }
            }
        }
        private bool IsInRange(int statValue, string statName)
        {
            if (statValue < 0 || statValue > 100)
            {
                throw new ArgumentException($"{statName} should be between 0 and 100.");
            }
            return true;
        }

    }
}
