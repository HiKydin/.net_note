using System;

namespace _40超市收银系统
{
    class Program
    {
        static void Main(string[] args)
        {
            SupperMarket sm = new SupperMarket();
            //展示货架
            sm.ShowPros();
            //与顾客交互
            sm.AskBuying();
        }
    }
}
