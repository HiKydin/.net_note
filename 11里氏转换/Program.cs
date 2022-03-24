using System;

namespace _11里氏转换
{
    class Program
    {
        static void Main(string[] args)
        {
            //1、子类可以赋值给父类(如果有一个地方需要一个父类作为参数，我们可以给一个子类作为代替)
            Student S = new Student();
            Preson P = S;
            Preson PP = new Student();
            //2、如果父类中装的是子类对象，那么可以将这个父类强转为子类对象
            Student SS = (Student)P;
            SS.StudentSayHello();
            //is 表示类型转换 转换成功为true 失败为false
            if(P is Student)
            {
                Console.WriteLine("转换成功");
            }
            else
            {
                Console.WriteLine("转换失败");
            }
            //as 表示类型转换 如果能转换则返回对应的对象，否则返回NULL 
            Teacher T = P as Teacher;//这个是失败的，因为P里面是Student
            Student SSS = P as Student;//这个是可以成功转换的
            SSS.StudentSayHello();


        }
    }
}