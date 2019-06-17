using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04数组去重
{
    class Program
    {
        static void Main(string[] args)
        {
            //可以用foreach遍历的对象需要继承IEnumerable接口以及
            //实现GetEnumerator    Serializable  

            //这里想要去重的话  可以通过分组来实现
            string[] strs = { "a", "b", "a", "aaa", "aaa", "b" };
            int[] nums = { 1, 2, 44, 6, 7, 7, 1, 2, 3, 3, 4, 4, 1, 1, 1, 3 };


            //int数组  去重 
            //第一种方法直接调用去重方法
            //nums = nums.Distinct().ToArray();
            //第二种方法   
            //先分组然后查询（是否有必要   有必要   分组之后返回类型为IEnumerable<IGroup<int,int>>  无法直接转换成数组形式）
            //nums = RemoveDuplicate(nums);
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.Write(nums[i] + "  ");
            //}

            //string 数组
            //strs = RemoveDuplicate(strs);
            //for (int i = 0; i < strs.Length; i++)
            //{

            //    Console.Write(strs[i]+"   ");
            //}

            Console.ReadKey();
        }

        /// <summary>
        /// 去掉重复项
        /// </summary>
        public static string[] RemoveDuplicate(string[] nums)
        {
            //先分组然后在查找
            return nums.GroupBy(p => p).Select(p => p.Key).ToArray();
        }


        /// <summary>
        /// 去掉重复项
        /// </summary>
        public static int[] RemoveDuplicate(int[] nums)
        {
            //先分组然后在查找
            return nums.GroupBy(p => p).Select(p => p.Key).ToArray();
        }


    }
}
