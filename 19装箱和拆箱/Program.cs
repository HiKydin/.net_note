using System;

namespace _19装箱和拆箱
{
    class Program
    {
        static void Main(string[] args)
        {
            //装箱：值类型转换为引用类型
            //拆箱：引用类型转换为值类型

            int n = 10;
            object o = n;//装箱
            int nn = (int)o;//拆箱
        }
    }
}
