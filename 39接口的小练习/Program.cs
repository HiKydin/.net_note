using System;

namespace _39接口的小练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //真的鸭子会游泳 木头鸭子不会游泳 橡皮鸭子会游泳
            ISwimmingable swim = new realDuck();
            swim.swim();
            ISwimmingable swim2 = new xinagDuck();
            swim2.swim();
        }
    }
    public interface ISwimmingable
    {
        void swim();
    }
    public class realDuck:ISwimmingable
    {
        public void swim()
        {
            Console.WriteLine("真的鸭子靠翅膀游泳");
        }
    }
    public class muDuck
    {

    }
    public class xinagDuck:ISwimmingable
    {
        public void swim()
        {
            Console.WriteLine("橡皮鸭子飘着游泳");
        }
    }
}
