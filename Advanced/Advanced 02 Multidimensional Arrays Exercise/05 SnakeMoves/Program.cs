using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = sizes[0];
            int cols = sizes[1];
            string snake = Console.ReadLine();
            Queue<char> snakeChars = new Queue<char>();
            for (int i = 0; i < snake.Length; i++)
            {
                snakeChars.Enqueue(snake[i]);
            }
            char[,] snakePath = new char[rows, cols];
            for (int row = 0; row < snakePath.GetLength(0); row++)
            {
                if (row%2==0)
                {
                    for (int col = 0; col < snakePath.GetLength(1); col++)
                    {
                        snakePath[row, col] = snakeChars.Peek();
                        snakeChars.Enqueue(snakeChars.Dequeue());
                    }
                }
                else
                {
                    for (int col = snakePath.GetLength(1)-1; col >-1 ; col--)
                    {
                        snakePath[row, col] = snakeChars.Peek();
                        snakeChars.Enqueue(snakeChars.Dequeue());
                    }
                }
                
            }
            PrintMatrix(snakePath);
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
