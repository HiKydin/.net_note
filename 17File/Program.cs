using System;
using System.IO;
using System.Text;

namespace _17File
{
    class Program
    {
        static void Main(string[] args)
        {
            //File.Create(@"C:\Users\admin\source\repos\17File\1.txt");
            //Console.WriteLine("创建成功");
            //File.Delete(@"C:\Users\admin\source\repos\17File\1.txt");
            //Console.WriteLine("删除成功");
            //File.Copy(@"C:\Users\admin\source\repos\17File\1.txt", @"C:\Users\admin\source\repos\17File\2.txt");
            //Console.WriteLine("复制成功");

            //string[] str=File.ReadAllLines(@"C:\Users\admin\source\repos\17File\服饰.txt", Encoding.Default);
            //foreach (string item in str)
            //{
            //    Console.WriteLine(item);
            //}

            //string str2 = File.ReadAllText(@"C:\Users\admin\source\repos\17File\服饰.txt", Encoding.Default);
            //Console.WriteLine(str2);

            //File.WriteAllLines(@"C:\Users\admin\source\repos\17File\1.txt",new string[] { "abc","efg" });
            //Console.WriteLine("ok");

            File.WriteAllText(@"C:\Users\admin\source\repos\17File\2.txt", "hahhahahhaha");
            Console.WriteLine("ok");

            File.AppendAllText(@"C:\Users\admin\source\repos\17File\2.txt", "看我有没有把你覆盖");
            Console.WriteLine("ok");
        }
    }
}
