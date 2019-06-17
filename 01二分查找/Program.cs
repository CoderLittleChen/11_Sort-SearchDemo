using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01二分查找
{
    class Program
    {
        static void Main(string[] args)
        {
            //二分查找的关键前提是数组必须是有序的   这个是大前提
            //在.Net中的内置类  Array类中内置了二分查找的方法  
            //其内部求Mid值的公式  mid=low+((hight-low)>>1)
            //这里位运算>>1  相当于/2，但是速度比除法运算快

            int[] nums = { 1, 3, 5, 8, 11, 23, 54, 55, 67, 88 };
            int index = BinarySearch(nums, 1);
            Console.WriteLine(index);
            Console.ReadKey();
        }


        /// <summary>
        /// 这里返回的是要查找的key在数组中的索引  
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static int BinarySearch(int[] nums, int key)
        {
            int left = 0;
            //这里right的值为nums.length-1更加好理解  都按照索引来计算
            int right = nums.Length - 1;
            //第一个问题 中间点怎样确定  当数组个数是奇数还是偶数不确定的时候   
            //直接除以2可以了    但是需要在while循环里面赋值
            //第二个问题  while循环的条件
            while (left <= right)
            {
                int middle = (left + right) / 2;
                if (nums[middle] == key)
                {
                    return middle;
                }
                if (nums[middle] > key)
                {
                    right = middle;
                }
                if (nums[middle] < key)
                {
                    left = middle;
                }
            }
            return -1;
        }


    }
}
