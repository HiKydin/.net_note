using System;

namespace _09继承
{
    class Program
    {
        static void Main(string[] args)
        {
            //继承的特性
            //1、继承的单根性：一个子类只能有一个父类
            //2、继承的传递性

            //子类没用继承父类的构造函数
            
            //object是所有类的基类
            
            //new关键字
            //1、创建对象
            //2、隐藏从父类那里继承过来的同名成员

            Student xs = new Student("张三",18,'男',90);
            xs.CHLSS();

        }
    }
}
