using System;
using System.Linq;

namespace _06_JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[][] matrix = ReadJagged(n);
            for (int i = 0; i < n-1; i++)
            {
                if (matrix[i].Length==matrix[i+1].Length)
                {
                    for (int j = 0; j < matrix[i].Length; j++)
                    {
                        matrix[i][j] *= 2;
                        matrix[i + 1][j] *= 2;
                    }                    
                }
                else
                {
                    matrix[i] = matrix[i].Select(x => x / 2).ToArray();
                    matrix[i + 1] = matrix[i + 1].Select(x => x / 2).ToArray();
                }
            }
            string input = Console.ReadLine();
            while (input!="End")
            {
                string[] tokens = input.Split();
                int row = int.Parse(tokens[1]);
                int col = int.Parse(tokens[2]);
                int value = int.Parse(tokens[3]);
                if (row<0||row>n-1||col<0||matrix[row].Length-1<col)
                {
                    input = Console.ReadLine();
                    continue;
                }
                if (tokens[0]=="Add")
                {
                    matrix[row][col] += value;
                }
                else
                {
                    matrix[row][col] -= value;
                }
                input = Console.ReadLine();
            }
            PrintJagged(matrix);
        }

        static double[][] ReadJagged(int n)
        {
            double[][] matrix = new double[n][];
            for (int i = 0; i < n; i++)
            {
                double[] nextLine = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
                matrix[i] = nextLine;
            }
            return matrix;
        }
        static void PrintJagged(double[][] jagged)
        {
            for (int row = 0; row < jagged.GetLength(0); row++)
            {
                Console.WriteLine(string.Join(" ", jagged[row]));
            }
        }
    }
}
