using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05静态和非静态的区别
{
    class Person
    {
        string s;

        public string S { get => s; set => s = value; }//ctel+r,e

        public void M1()
        {
            Console.WriteLine("我是一个非静态类");
        }
        public static void M2()
        {
            Console.WriteLine("我是一个静态类");
        }
        //在一个非静态类中，既可以有非静态成员/实例成员，也可以有静态成员
        //在调用实例成员的时候，需要使用对象名.实例成员; m1.M1()
        //在调用静态成员的时候，需要使用类名.静态成员;  Person.M2()
        //静态方法只能访问静态成员，不能访问实例成员;
        //实例方法可以访问实例成员，也能访问静态成员;
        //静态类中只能声明静态成员，不能声明实例成员;
        //实例类中可以声明实例成员，也能声明静态成员;
        //静态类无法被实例化（不能new）
        

        //工具类，建议设为静态类
        //静态类在整个项目中资源共享（类不占内存，静态类占内存（静态存储区域））  堆  栈  静态存储区域 BSS
    }
}
