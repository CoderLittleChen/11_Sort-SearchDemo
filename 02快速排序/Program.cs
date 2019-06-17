using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02快速排序
{
    class Program
    {
        static void Main(string[] args)
        {
            //排序（内部排序）的几种分类:插入类排序  交换类排序   选择类排序   归并排序等几种
            //时间复杂度：O（N*logN）
            //1、先从数组中取出一个数作为基准    取数原则是什么？
            //2、将比基准数大的放到右边，小于或者等于它的数放在左边
            //3、再对左右区间重复第二步  直到区间中只有一个数
            //int[] nums = { 11, 3, 5, 66, 4, 3, 11, 9, 200, 133, 46, 78, 34, 15 };
            int[] nums = { 6, 1, 2, 7, 9, 3, 4, 5, 10, 8 };
            QuickSort(nums, 0, nums.Length - 1);
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + "  ");
            }
            Console.ReadKey();
        }

        /// <summary>
        /// 快速排序入口  
        /// </summary>
        public static void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                //这里返回的是在经过第一次左右分区后的基准数的Index
                int index = Partition(arr, low, high);
                //对左区间递归排序
                QuickSort(arr, low, index - 1);
                //对右区间递归排序
                QuickSort(arr, index + 1, high);
            }
        }

        /// <summary>
        /// 可正确实现
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="low"></param>
        /// <param name="high"></param>
        /// <returns></returns>
        //private static int Partition(int[] arr, int low, int high)
        //{
        //    int i, j, temp, t;
        //    i = low;
        //    j = high;
        //    //temp就是基准位
        //    temp = arr[low];

        //    while (i < j)
        //    {
        //        //先看右边，依次往左递减
        //        while (temp <= arr[j] && i < j)
        //        {
        //            j--;
        //        }
        //        //再看左边，依次往右递增
        //        while (temp >= arr[i] && i < j)
        //        {
        //            i++;
        //        }
        //        //如果满足条件则交换
        //        if (i < j)
        //        {
        //            t = arr[j];
        //            arr[j] = arr[i];
        //            arr[i] = t;
        //        }
        //    }
        //    //最后将基准为与i和j相等位置的数字交换   这里其实arr[low]=temp
        //    arr[low] = arr[i];
        //    arr[i] = temp;
        //    //因为到最后i和j的值是相等的  所有返回i或者j都可以
        //    return i;
        //}



        //这样写也正确
        private static int Partition(int[] arr, int low, int high)
        {
            int i = low, j = high;
            int temp = arr[i]; // 确定第一个元素作为"基准值"

            while (i < j)
            {
                // Stage1:从右向左扫描直到找到比基准值小的元素
                while (i < j && arr[j].CompareTo(temp) >= 0)
                {
                    j--;
                }
                // 将比基准值小的元素移动到基准值的左端
                arr[i] = arr[j];

                // Stage2:从左向右扫描直到找到比基准值大的元素
                while (i < j && arr[i].CompareTo(temp) <= 0)
                {
                    i++;
                }
                // 将比基准值大的元素移动到基准值的右端
                arr[j] = arr[i];
            }

            // 记录归位
            arr[i] = temp;

            return i;
        }



    }
}
