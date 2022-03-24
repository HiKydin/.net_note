using System;
using System.Collections;

namespace _15Hashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hashtable 键值对集合
            Hashtable ht = new Hashtable();
            ht.Add(1, "张三");
            ht.Add(2, true);
            ht.Add(3, '男');
            ht.Add(false, "错误");
            Console.WriteLine(ht[false]);

            ht[1] = "把张三干掉";//重点

            for(int i=0;i<ht.Count;i++)
            {
                Console.WriteLine(ht[i]);
            }
            Console.WriteLine("----------------------");
            foreach (var item in ht.Keys)
            {
                Console.WriteLine("键是{0}---值是{1}", item, ht[item]);
            }


            //ht.Clear();
            //ht.Remove();
            //ctrl+d 复制一行
        }
    }
}
