using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSwapMethodStrings
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Box> boxList = new List<Box>();
            for (int i = 0; i < n; i++)
            {
                Object item = Console.ReadLine();
                Box newBox = new Box(item);
                boxList.Add(newBox);
            }
            int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            SwapElements(boxList, indexes[0], indexes[1]);
            foreach (var box in boxList)
            {
                Console.WriteLine(box.ToString());
            }
        }
        public static void SwapElements(List<Box> list, int index1, int index2)
        {
            Box temp = list[index1];
            list[index1] = list[index2];
            list[index2] = temp;
        }
    }
}
