using System;

namespace _38显示实现接口
{
    class Program
    {
        static void Main(string[] args)
        {
            IFlyable fly = new Bird();
            fly.fly();
            Bird bird = new Bird();
            bird.fly();
        }
    }
    public class Bird:IFlyable
    {
        public void fly()
        {
            Console.WriteLine("鸟会飞");
        }
        void IFlyable.fly()
        {
            Console.WriteLine("我也会飞");
        }
    }
    public interface IFlyable
    {
        void fly();
    }
}
