using System;
using System.Collections.Generic;

namespace FootballTeamGenerator
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, Team> teams = new Dictionary<string, Team>();
            while (input[0] != "END")
            {
                try
                {
                    string teamName = input[1];
                    if (!teams.ContainsKey(teamName) && input[0] != "Team")
                    {
                        throw new ArgumentException($"Team {teamName} does not exist.");
                    }
                    //"Team;{TeamName}"
                    else if (input[0] == "Team")
                    {
                        Team team = new Team(teamName);
                        if (!teams.ContainsKey(teamName))
                        {
                            teams.Add(teamName, team);
                        }
                        else
                        {
                            throw new ArgumentException("Team already exists");
                        }
                    }
                    else if (input[0] == "Add")
                    {
                        // "Add;{TeamName};{PlayerName};{Endurance};{Sprint};{Dribble};{Passing};{Shooting}"
                        try
                        {
                            Player player = new Player(input[2], int.Parse(input[3]), int.Parse(input[4]), int.Parse(input[5]), int.Parse(input[6]), int.Parse(input[7]));
                            teams[teamName].AddPlayer(player);
                        }
                        catch (Exception ex)
                        {

                            Console.WriteLine(ex.Message);
                        }

                    }
                    else if (input[0] == "Remove")
                    {
                        try
                        {
                            //Remove;{TeamName};{PlayerName}
                            string playerName = input[2];
                            teams[teamName].RemovePlayer(playerName);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                    else if (input[0] == "Rating")
                    {
                        int rating = teams[teamName].GetRating();
                        Console.WriteLine($"{teamName} - {rating}");
                    }
                }
                catch(ArgumentException argEx)
                {
                    Console.WriteLine(argEx.Message);
                }

                input = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
            }
        }
    }
}
