using System;
using System.IO;

namespace _23用FileStream复制多媒体文件
{
    class Program
    {
        static void Main(string[] args)
        {
            //要复制的文件
            string sorce = @"C:\Users\admin\source\repos\23用FileStream复制多媒体文件\1.png";
            //复制文件的路径
            string teget= @"C:\Users\admin\source\repos\23用FileStream复制多媒体文件\2.png";
            FileCopy(sorce, teget);
            Console.WriteLine("复制成功");
        }

        //一个复制文件的方法
        public static void FileCopy(string sorce,string teget)
        {
            //先把文件读出来
            using (FileStream fsRead=new FileStream(sorce,FileMode.Open,FileAccess.ReadWrite))
            {
                //写文件
                using (FileStream fsWrite=new FileStream(teget, FileMode.OpenOrCreate,FileAccess.ReadWrite))
                {
                    byte[] buffer = new byte[1024*1024*5];
                    while(true)//一次可能读不完，要循环读
                    {
                        //读取到的文件的长度
                        int r = fsRead.Read(buffer, 0, buffer.Length);
                        if (r == 0)
                        {
                            break;
                        }
                        fsWrite.Write(buffer, 0, r);
                    }
                }
            }
        }
    }
}
