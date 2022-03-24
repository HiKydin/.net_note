using System;

namespace _26多态练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //真的鸭子嘎嘎叫 木头鸭子吱吱叫 橡皮鸭子唧唧叫
            xiangya xy1 = new xiangya();
            muya my1 = new muya();
            xiangya xy2 = new xiangya();
            muya my2 = new muya();
            zhenya[] yazi = { xy1, my1, xy2, my2 };
            for(int i=0;i<yazi.Length;i++)
            {
                yazi[i].SayHello();
            }
        }
    }
}
