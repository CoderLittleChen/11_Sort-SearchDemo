using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08二分查找
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 5, 7, 11, 23, 29, 45, 99 };
            int index = BinarySearch(nums, 23);
            Console.WriteLine(index);
            Console.ReadKey();

        }

        public static int BinarySearch(int[] nums, int key)
        {
            int low = 0;
            int high = nums.Length - 1;
            //这里注意一定是<=  才可以  
            while (low <= high)
            {
                int middle = (low + high) / 2;
                if (nums[middle] == key)
                {
                    return middle;
                }
                else if (nums[middle] > key)
                {
                    high = middle - 1;
                }
                else if (nums[middle] < key)
                {
                    low = middle + 1;
                }
            }
            return -1;
        }

    }
}
