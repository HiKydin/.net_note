using System;

namespace _05静态和非静态的区别
{
    class Program
    {
        static void Main(string[] args)
        {
            Person m1 = new Person();
            m1.M1();//实例方法
            Person.M2();//静态方法
        }
    }
}
