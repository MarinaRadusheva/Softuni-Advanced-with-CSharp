using System;
using System.Linq;

namespace _08_Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n =int.Parse(Console.ReadLine());           
            int[,] matrix = ReadMatrix(n);
            if (n != 0)
            {
                string[] coordinates = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < coordinates.Length; i++)
                {
                    int[] bomb = coordinates[i].Split(",", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                    int row = bomb[0];
                    int col = bomb[1];
                    int value = matrix[row, col];
                    if (value<=0)
                    {
                        continue;
                    }
                    if (IsInside(row - 1, col - 1, n))
                    {
                        if (matrix[row - 1, col - 1] > 0)
                        {
                            matrix[row - 1, col - 1] -= value;
                        }

                    }
                    if (IsInside(row - 1, col, n))
                    {
                        if (matrix[row - 1, col] > 0)
                        {
                            matrix[row - 1, col] -= value;
                        }
                    }
                    if (IsInside(row - 1, col + 1, n))
                    {
                        if (matrix[row - 1, col + 1] > 0)
                        {
                            matrix[row - 1, col + 1] -= value;
                        }
                    }
                    if (IsInside(row, col - 1, n))
                    {
                        if (matrix[row, col - 1] > 0)
                        {
                            matrix[row, col - 1] -= value;
                        }
                    }
                    if (IsInside(row, col + 1, n))
                    {
                        if (matrix[row, col + 1] > 0)
                        {
                            matrix[row, col + 1] -= value;
                        }
                    }
                    if (IsInside(row + 1, col - 1, n))
                    {
                        if (matrix[row + 1, col - 1] > 0)
                        {
                            matrix[row + 1, col - 1] -= value;
                        }
                    }
                    if (IsInside(row + 1, col, n))
                    {
                        if (matrix[row + 1, col] > 0)
                        {
                            matrix[row + 1, col] -= value;
                        }
                    }
                    if (IsInside(row + 1, col + 1, n))
                    {
                        if (matrix[row + 1, col + 1] > 0)
                        {
                            matrix[row + 1, col + 1] -= value;
                        }
                    }
                    matrix[row, col] = 0;
                }
            }
            PrintOutput(matrix);
        }
        static int[,] ReadMatrix(int n)
        {
            int[,] matrix = new int[n,n];
            for (int row = 0; row < n; row++)
            {
                int[] rowElements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = rowElements[col];
                }
            }
            return matrix;
        }
        static void PrintOutput(int[,] matrix)
        {
            int count = 0;
            int sum = 0;
            foreach (var item in matrix)
            {
                if (item>0)
                {
                    count++;
                    sum += item;
                }
            }
            Console.WriteLine($"Alive cells: { count}");
            Console.WriteLine($"Sum: { sum}");

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
        static bool IsInside(int row, int col, int n)
        {
            if (row>=0&&row<n&&col>=0&&col<n)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
