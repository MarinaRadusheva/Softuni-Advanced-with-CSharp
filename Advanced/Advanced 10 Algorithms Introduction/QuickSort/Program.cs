using System;
using System.Linq;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            QuickSort(array, 0, array.Length - 1);
            Console.WriteLine(string.Join(" ", array));
        }

        private static void QuickSort<T>(T[] array, int left, int right) where T : IComparable
        {
            if (left<right)
            {
                int pivotIndex = Partition(array, left, right);
                QuickSort(array, left, pivotIndex - 1);
                QuickSort(array, pivotIndex + 1, right);
            }
        }
        private static int Partition<T>(T[] array, int left, int right) where T : IComparable
        {
            int lowerIndex = left - 1;
            T pivotValue = array[right];
            for (int i = left; i < right; i++)
            {
                if (array[i].CompareTo(pivotValue)<0)
                {
                    lowerIndex++;
                    T temp = array[lowerIndex];
                    array[lowerIndex] = array[i];
                    array[i] = temp;
                }
            }
            T temp2 = array[lowerIndex + 1];
            array[lowerIndex + 1] = array[right];
            array[right] = temp2;
            return lowerIndex + 1;
            //T pivotValue = array[right];
            //while (true)
            //{
            //    while (array[left].CompareTo(pivotValue)<0)
            //    {
            //        left++;
            //    }
            //    while (array[right].CompareTo(pivotValue)>0)
            //    {
            //        right--;
            //    }
            //    if (left<right)
            //    {
            //        if (array[left].Equals(array[right]))
            //        {
            //            return right;
            //        }
            //        T temp = array[left];
            //        array[left] = array[right];
            //        array[right] = temp;
            //    }
            //    else
            //    {
            //        return right;
            //    }
            //}
        }
    }
}
