using System;
using System.IO;
using System.Text;

namespace _24StreamReader和StreamWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            ////使用StreamReader读取一个文件
            //using (StreamReader sr=new StreamReader(@"C:\Users\admin\source\repos\24StreamReader和StreamWriter\Program.cs",Encoding.Default))
            //{
            //    while(!sr.EndOfStream)
            //    {
            //        Console.WriteLine(sr.ReadLine());
            //    }
            //}
            //使用StreamWriter写入一个文件
            using (StreamWriter sw=new StreamWriter(@"C:\Users\admin\source\repos\24StreamReader和StreamWriter\1.txt",true))
            {
                sw.WriteLine("hhahahahhaha");
            }
        }
    }
}
