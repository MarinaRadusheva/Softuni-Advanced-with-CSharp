using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> clothes = new Stack<int>(nums);
            int capacity = int.Parse(Console.ReadLine());
            int racks = 1;
            int sum = 0;
            if (clothes.Max()==0||capacity==0)
            {
                racks = 0;
                Console.WriteLine(0);
                return;
            }
            while (clothes.Count!=0)
            {
                int nextPiece = clothes.Peek();
                if (sum+nextPiece<capacity)
                {
                    sum += nextPiece;
                    clothes.Pop();
                }
                else if (sum+nextPiece==capacity)
                {
                    sum = 0;
                    clothes.Pop();
                    if (clothes.Count>0)
                    {
                        racks++;
                    }
                    
                   
                }
                else
                {
                    sum = nextPiece;
                    racks++;
                    clothes.Pop();
                }
            }
            
            Console.WriteLine(racks);
        }
    }
}
