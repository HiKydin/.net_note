using System;
namespace _01方法的使用
{
    class Program
    {
        static void Main(string[] args)
        {
            #region GetMaxMinSum
            //int max, min, sum;
            //int[] number = new int[10];
            //n = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < n; i++)
            //{
            //    number[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //GetMaxMinSum(number, out max, out min, out sum);
            //Console.WriteLine("最大值为：{0}\n最小值为：{1}\n总和为：{2}", max, min, sum);
            #endregion
            #region str求最大
            //string[] str = new string[100];
            //Console.WriteLine(n);
            //for(int i=0;i<n;i++)
            //{
            //    str[i] = Console.ReadLine();
            //}
            //int longstr=Program.HowLong(str,n);
            #endregion
            #region sort
            int[] num = new int[10];
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<n;i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            Program.Rank(num,n);
            #endregion
        }
        #region GetMaxMinSum
        //public static void GetMaxMinSum(int[] nums, out int max, out int min, out int sum)
        //{
        //    max = nums[0];
        //    min = nums[0];
        //    sum = 0;
        //    for (int i = 0; i < n; i++)
        //    {
        //        if (nums[i] > max)
        //        {
        //            max = nums[i];
        //        }
        //    }
        //    for (int i = 0; i < n; i++)
        //    {
        //        if (nums[i] < min)
        //        {
        //            min = nums[i];
        //        }
        //    }
        //    for (int i = 0; i <n; i++)
        //    {
        //        sum += nums[i];
        //    }
        #endregion
        #region str求最大
        //public static int HowLong(string[] str,int n)
        //{
        //    for(int i=0;i<n;i++)
        //    {
        //        if(string[i].)
        //    }
        //}
        #endregion
        #region sort
        public static void Rank(int[] num, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (num[i] > num[j])
                    {
                        num[i] ^= num[j];
                        num[j] ^= num[i];
                        num[i] ^= num[j];
                    }
                }
            }
            Console.WriteLine(num[n - 1]);
        }
        #endregion
    }
}
