using System;
using System.Collections;

namespace _14集合的两个练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建一个集合，里面添加一些数字，求平均值与和

            //ArrayList list = new ArrayList();
            //list.AddRange(new int[] { 1, 2,3, 4, 5,6 });
            //int num = 0;
            //for(int i=0;i<list.Count;i++)
            //{
            //    num += (int)list[i];
            //}
            //Console.WriteLine("平均值是{0}，和是{1}", num / list.Count, num);

            //写一个长度为10的集合，要求在里面随机存放10个数字（0-9）（所有数字不重复）
            ArrayList list = new ArrayList();
            Random r = new Random();
            for(int i=0;i<10;i++)
            {
                int rMember = r.Next(0, 10);
                if(!list.Contains(rMember))
                {
                    list.Add(rMember);
                }
                else
                {
                    i--;//重点
                }
            }
            for(int i=0;i<list.Count;i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
