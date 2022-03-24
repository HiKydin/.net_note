using System;

namespace _04类与对象
{
    class Program
    {
        static void Main(string[] args)
        {
            Person sq = new Person();
            sq.Name = "孙权";
            sq.Age = -18;
            sq.Gender = '女';
            sq.CHLSS();
            //类的实例化
            //类是不占内存的，对象占内存

        }
    }
}
