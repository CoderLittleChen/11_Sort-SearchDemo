using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07快速排序复习
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 1, 4, 99, 4, 5, 23, 19 };
            QuickSort(nums, 0, nums.Length - 1);
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + "  ");
            }
            Console.ReadKey();
        }

        public static void QuickSort(int[] arr, int low, int high)
        {
            if (low<high)
            {
                int index = Partition(arr, low, high);
                QuickSort(arr, low, index - 1);
                QuickSort(arr, index + 1, high);
            }
        }


        public static int Partition(int[] arr, int low, int high)
        {
            int i = low, j = high, temp;
            //默认数组第一个元素为基准值
            temp = arr[low];

            while (i < j)
            {
                //这里注意相同的情况
                while (i < j && arr[j] >= temp)
                {
                    j--;
                }
                arr[i] = arr[j];
                while (i < j && arr[i] <= temp)
                {
                    i++;
                }
                arr[j] = arr[i];
            }
            arr[i] = temp;
            return i;

        }

    }
}
