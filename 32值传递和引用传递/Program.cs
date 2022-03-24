using System;

namespace _32值传递和引用传递
{
    class Program
    {
        static void Main(string[] args)
        {
            //值类型:int double char decimal bool enum struct    存在栈中
            //引用类型:string 数组 自定义类 集合 object 接口      存在堆中

            //值类型在复制的时候，传递的是这个值的本身
            //引用类型在复制的时候，传递的是对这个对象的引用

            //字符串有不可变性  会重新开空间

            int num = 10;
            add(num);
            Console.WriteLine(num);
            add2(ref num);
            Console.WriteLine(num);
            //ref能将一个变量以参数的方式传进去再返回出来
        }
        public static void add(int num)
        {
            num += 10;
        }
        public static void add2(ref int num)
        {
            num += 10;
        }
    }
}
