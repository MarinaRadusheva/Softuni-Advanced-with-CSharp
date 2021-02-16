using System;
using System.Diagnostics;
using System.Linq;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            MergeSort<int> sorter = new MergeSort<int>();
            var sorted = sorter.Sort(nums);
            Console.WriteLine(string.Join(" ", sorted));
            //char[] chars = Console.ReadLine().Split().Select(char.Parse).ToArray();
            //MergeSort<char> sorter = new MergeSort<char>();
            //var sorted = sorter.Sort(chars);
            //Console.WriteLine(string.Join(", ", sorted));
        }
    }
        
    public class MergeSort<T> where T : IComparable
    {
        public T[] Sort(T[] nums)
        {
            if (nums.Length == 1)
            {
                return nums;
            }
            int middle = nums.Length / 2;
            T[] leftArr = new T[middle];
            T[] rightArr = new T[nums.Length - middle];
            for (int i = 0; i < middle; i++)
            {
                leftArr[i] = nums[i];
            }
            for (int i = middle, j = 0; i < nums.Length; i++, j++)
            {
                rightArr[j] = nums[i];
            }
            leftArr = Sort(leftArr);
            rightArr = Sort(rightArr);
            return Merge(leftArr, rightArr);
        }
        private static T[] Merge(T[] leftArr, T[] rightArr)
        {
            T[] resultArr = new T[leftArr.Length + rightArr.Length];
            int leftIndex = 0;
            int rightIndex = 0;
            for (int i = 0; i < resultArr.Length; i++)
            {
                if (leftIndex == leftArr.Length || (rightIndex < rightArr.Length && ((leftArr[leftIndex]).CompareTo(rightArr[rightIndex]) > 0)))
                {
                    resultArr[i] = rightArr[rightIndex++];
                }
                else if (rightIndex == rightArr.Length || (leftIndex < leftArr.Length && (rightArr[rightIndex].CompareTo(leftArr[leftIndex]) >= 0)))
                {
                    resultArr[i] = leftArr[leftIndex++];
                }
            }
            return resultArr;
        }
    }
}
