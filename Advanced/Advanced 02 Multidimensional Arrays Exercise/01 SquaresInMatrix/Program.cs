using System;
using System.Linq;

namespace _01_SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            char[,] matrix = ReadMatrix(sizes[0], sizes[1]);
            int count = 0;
            for (int row = 0; row < matrix.GetLength(0)-1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1)-1; col++)
                {
                    
                    if (matrix[row,col]==matrix[row,col+1]&& matrix[row, col + 1]==matrix[row+1,col]&& matrix[row + 1, col] == matrix[row+1,col+1])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
        static char[,] ReadMatrix(int rows, int cols)
        {
            char[,] matrix = new char[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                char[] rowElements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowElements[col];
                }
            }
            return matrix;
        }
    }
}
