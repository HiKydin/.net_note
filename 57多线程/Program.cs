using System;
using System.Diagnostics;

namespace _57多线程
{
    class Program
    {
        static void Main(string[] args)
        {
            //进程：我们每一个应用程序都是一个进程
            //而进程又是由多个线程组成的

            //打印当前所有进程
            Process[] pros = Process.GetProcesses();
            foreach (var item in pros)
            {
                Console.WriteLine(item);
            }

            //获取当前应用的进程
            Console.WriteLine(Process.GetCurrentProcess().ToString());
            
            //打开画图
            Process.Start("mspaint");

        }
    }
}
