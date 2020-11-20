using System;
using System.Collections.Generic;
using System.Linq;

namespace _10_MutantBunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            char[,] field = ReadMatrix(size[0], size[1]);
            int currentRow = 0;
            int currentCol = 0;
            bool dead = false;
            bool isOut = false;
            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    if (field[row, col] == 'P')
                    {
                        currentRow = row;
                        currentCol = col;
                    }
                }
            }
            string path = Console.ReadLine();
            for (int i = 0; i < path.Length; i++)
            {
                field[currentRow, currentCol] = '.';
                char direction = path[i];
                switch (direction)
                {
                    case 'U':
                        if (currentRow > 0)
                        {
                            currentRow--;
                        }
                        else
                        {
                            isOut = true;
                        }
                        break;
                    case 'R':
                        if (currentCol < field.GetLength(1) - 1)
                        {
                            currentCol++;
                        }
                        else
                        {
                            isOut = true;
                        }
                        break;
                    case 'D':
                        if (currentRow < field.GetLength(0) - 1)
                        {
                            currentRow++;
                        }
                        else
                        {
                            isOut = true;
                        }
                        break;
                    case 'L':
                        if (currentCol > 0)
                        {
                            currentCol--;
                        }
                        else
                        {
                            isOut = true;
                        }
                        break;
                    default:
                        break;
                }
                if (isOut)
                {
                    SpreadBunnies(field);
                    break;
                }
                if (field[currentRow, currentCol] == 'B')
                {
                    dead = true;
                    SpreadBunnies(field);
                    break;
                }
                else
                {
                    field[currentRow, currentCol] = 'P';
                }
                SpreadBunnies(field);
                if (field[currentRow, currentCol] == 'B')
                {
                    dead = true;
                    break;
                }
            }
            PrintMatrix(field);
            if (dead)
            {

                Console.WriteLine($"dead: { currentRow} { currentCol}");
            }
            if (isOut)
            {
                Console.WriteLine($"won: {currentRow} {currentCol}");
            }
        }

        private static void SpreadBunnies(char[,] field)
        {
            List<int[]> bunnies = new List<int[]>();
            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    if (field[row, col] == 'B')
                    {
                        int[] newBunny = new int[] { row, col };
                        bunnies.Add(newBunny);
                    }
                }
            }
            for (int i = 0; i < bunnies.Count; i++)
            {
                int row = bunnies[i][0];
                int col = bunnies[i][1];

                if (row > 0)
                {
                    field[row - 1, col] = 'B';
                }
                if (col < field.GetLength(1) - 1)
                {
                    field[row, col + 1] = 'B';
                }
                if (row < field.GetLength(0) - 1)
                {
                    field[row + 1, col] = 'B';
                }
                if (col > 0)
                {
                    field[row, col - 1] = 'B';
                }
            }
        }

        static char[,] ReadMatrix(int rows, int cols)
        {
            char[,] matrix = new char[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                string nextLine = Console.ReadLine();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = nextLine[col];
                }
            }
            return matrix;
        }
        static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
