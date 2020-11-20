using System;

namespace _07_KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] board = new char[n, n];
            for (int i = 0; i < n; i++)
            {
                string newLine = Console.ReadLine();
                for (int j = 0; j < n; j++)
                {
                    board[i, j] = newLine[j];
                }
            }
            int count = 0;
            int maxHits = 8;
            while (maxHits!=0)
            {
                for (int row = 0; row < board.GetLength(0); row++)
                {
                    
                    for (int col = 0; col < board.GetLength(1); col++)
                    {
                        int hits = 0;
                        if (board[row, col] == 'K')
                        {
                            if (row>1&&col>0)
                            {
                                if (board[row - 2, col - 1] == 'K')
                                {
                                    hits++;
                                }
                            }
                            if (row>1&&col+1<n)
                            {
                                if (board[row - 2, col + 1] == 'K')
                                {
                                    hits++;
                                }
                            }
                            if (row>0&&col>1)
                            {
                                if (board[row - 1, col - 2] == 'K')
                                {
                                    hits++;
                                }
                            }
                            if (row>0&&col+2<n)
                            {
                                if (board[row - 1, col + 2] == 'K')
                                {
                                    hits++;
                                }
                            }
                            if (row+1<n&&col>1)
                            {
                                if (board[row + 1, col - 2] == 'K')
                                {
                                    hits++;
                                }
                            }
                            if (row+1<n&&col+2<n)
                            {
                                if (board[row + 1, col + 2] == 'K')
                                {
                                    hits++;
                                }
                            }
                            if (row+2<n&&col>0)
                            {
                                if (board[row + 2, col - 1] == 'K')
                                {
                                    hits++;
                                }
                            }
                            if (row+2<n&&col+1<n)
                            {
                                if (board[row + 2, col + 1] == 'K')
                                {
                                    hits++;
                                }
                            }
                            
                            
                        }
                        if (hits==maxHits)
                        {
                            count++;
                            board[row, col] = '0';
                        }
                    }
                }
                maxHits--;
            }
            Console.WriteLine(count);
        }
    }
}
