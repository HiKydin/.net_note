using System;
using System.Collections.Generic;

namespace _21集合的三个练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //将一个数组中的奇数放到一个集合中，偶数放到另一个集合中
            //最终将两个集合合并到一个集合中，奇数显示在左边，偶数显示在右边
            //int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //List<int> listOu = new List<int>();
            //List<int> listJi = new List<int>();
            //for(int i=0;i<num.Length;i++)
            //{
            //    if(num[i]%2==0)
            //    {
            //        listOu.Add(num[i]);
            //    }
            //    else
            //    {
            //        listJi.Add(num[i]);
            //    }
            //}
            //listJi.AddRange(listOu);
            //foreach (int item in listJi)
            //{
            //    Console.Write(item +" ");
            //}


            ////提示用户输入一个字符串，通过foreach循环将输入的字符串赋值给每一个字符
            //Console.WriteLine("请输入一个字符串");
            //string input = Console.ReadLine();
            //char[] chs = new char[input.Length];
            //int i = 0;
            //foreach (var item in input)
            //{
            //    chs[i] = item;
            //    i++;
            //}
            //foreach (var item in chs)
            //{
            //    Console.WriteLine(item);
            //}

            //统计Welcome to China中每个字符出现的次数，不考虑大小写
            string str = "Welcome to China";
            Dictionary<char, int> dic = new Dictionary<char, int>();

            for(int i=0;i<str.Length;i++)
            {
                if(str[i]==' ')
                {
                    continue;
                }
                if(dic.ContainsKey(str[i]))
                {
                    dic[str[i]]++;
                }
                else
                {
                    dic[str[i]] = 1;
                }
            }
            foreach (KeyValuePair<char,int> kv in dic)
            {
                Console.WriteLine("单词{0}出现了{1}次", kv.Key, kv.Value);
            }
        }
    }
}
