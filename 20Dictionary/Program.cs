using System;
using System.Collections.Generic;

namespace _20Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1, "张三");
            dic.Add(2, "李四");
            dic.Add(3, "王五");
            foreach (KeyValuePair<int,string> kv in dic)
            {
                Console.WriteLine("{0}-------{1}", kv.Key, kv.Value);
            }
        }
    }
}
