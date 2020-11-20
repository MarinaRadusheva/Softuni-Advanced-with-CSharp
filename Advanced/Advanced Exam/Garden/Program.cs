using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;

namespace Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[,] garden = new int[sizes[0], sizes[1]];
            for (int row = 0; row < garden.GetLength(0); row++)
            {
                for (int col = 0; col < garden.GetLength(1); col++)
                {
                    garden[row, col] = 0;
                }
            }
            string command = Console.ReadLine();
            List<Plant> plants = new List<Plant>();
            while (command != "Bloom Bloom Plow")
            {
                int[] flowerPosition = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int plantRow = flowerPosition[0];
                int plantCol = flowerPosition[1];
                if (PositionIsValid(plantRow, plantCol, sizes[0], sizes[1]))
                {
                    Plant newPlant = new Plant(plantRow, plantCol);
                    plants.Add(newPlant);
                }
                else
                {
                    Console.WriteLine("Invalid coordinates.");
                }
                command = Console.ReadLine();
            }
            for (int i = 0; i < plants.Count; i++)
            {
                Bloom(plants[i].Row, plants[i].Col, ref garden);
            }
            for (int i = 0; i < garden.GetLength(0); i++)
            {
                for (int j = 0; j < garden.GetLength(1); j++)
                {
                    Console.Write(garden[i,j]+" ");
                }
                Console.WriteLine();
            }

        }
        static void Bloom(int row, int col, ref int[,] garden)
        {
            for (int i = 0; i < garden.GetLength(0); i++)
            {
                garden[i, col]++;
            }
            for (int i = 0; i < garden.GetLength(1); i++)
            {
                garden[row, i]++;
            }
            garden[row, col]--;
        }
        static bool PositionIsValid(int row, int col, int maxRow, int maxCol)
        {
            if (row<0||row>=maxRow||col<0||col>=maxCol)
            {
                return false;
            }
            return true;
        }
    }
    public class Plant
    {
        public Plant(int row, int col)
        {
            this.Row = row;
            this.Col = col;
        }
        public int Row { get; set; }
        public int Col { get; set; }
    }
}
