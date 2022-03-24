using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40超市收银系统
{
    class SupperMarket
    {
        CuangKu ck = new CuangKu();
        
        /// <summary>
        /// 创建超市的时候就进货
        /// </summary>
        public SupperMarket()
        {
            ck.JinPros("Bee",100);
            ck.JinPros("Note", 100);
            ck.JinPros("Apple", 100);
            ck.JinPros("Banana", 100);
        }

        public void AskBuying()
        {
            Console.WriteLine("欢迎光临，请问需要什么?");
            Console.WriteLine("我们有Bee、Note、Apple、Banana");
            string _need = Console.ReadLine();
            Console.WriteLine("您需要多少？");
            int _needcount = Convert.ToInt32(Console.ReadLine());
            //取货
            Productfather[] pf= ck.QuPros(_need, _needcount);
            //计算价钱
            double realMoney = Money(pf);
            Console.WriteLine("您总共应付{0}元",realMoney);
            Console.WriteLine("请选择您的打折方式：1---不打折，2---打九折，3---打85折，4---买300送50，5---买500送100");
            string input = Console.ReadLine();
            //通过简单工厂的设计模式根据用户的输入获得一个对象
            CatFather cal = GetMoney(input);
            double totalMoney= cal.GetMoney(realMoney);
            Console.WriteLine("打完折后，您应付{0}元", totalMoney);

            Console.WriteLine("这是您的小票，请拿好，欢迎下次光临");
            foreach (var item in pf)
            {
                Console.WriteLine("商品名称:" + item.Name + "\t" + "商品单价:" + item.Price + "\t" + "商品编号:" + item.Id + "\n");
            }

        }

        /// <summary>
        /// 根据用户的输入返回一个打折方案的对象
        /// </summary>
        /// <param name="input">用户的选择</param>
        /// <returns>返回父类对象，但里面装的是子类</returns>
        public CatFather GetMoney(string input)
        {
            CatFather pf = null;
            switch(input)
            {
                case "1":
                    pf = new NoCat();
                    break;
                case "2":
                    pf = new CalRatecs(0.9);
                    break;
                case "3":
                    pf=new CalRatecs(0.85);
                    break;
                case "4":
                    pf = new CalMN(300, 50);
                    break;
                case "5":
                    pf = new CalMN(500, 100);
                    break;
            }
            return pf;
        }
        /// <summary>
        /// 计算购物车总金额
        /// </summary>
        /// <param name="pf">购物车</param>
        /// <returns>总价</returns>
        public double Money(Productfather[] pf)
        {
            double realMoney = 0;
            for(int i=0;i<pf.Length;i++)
            {
                realMoney += pf[i].Price;
            }
            return realMoney;
        }

        public void ShowPros()
        {
            ck.ShowPros();
        }
    }
}
