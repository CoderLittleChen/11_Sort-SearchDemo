using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03冒泡排序
{
    class Program
    {
        static void Main(string[] args)
        {
            //冒泡排序   怎样对外层循环和内层循环进行优化
            int[] nums = { 1, 3, 4, 5, 66, 7, 23, 9 };
            BubbleSort(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + "  ");
            }
            Console.ReadKey();

        }

        /// <summary>
        /// 冒泡排序及优化
        /// </summary>
        /// <param name="nums"></param>
        public static void BubbleSort(int[] nums)
        {
            int temp;
            bool isChange = false;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length - 1 - i; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                }
            }
        }

    }
}
