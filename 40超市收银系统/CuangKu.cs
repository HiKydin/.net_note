using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40超市收银系统
{
    class CuangKu
    {
        List<List<Productfather>> list=new List<List<Productfather>>();
        /// <summary>
        /// 向顾客展示货物
        /// </summary>
        public void ShowPros()
        {
            foreach (var item in list)
            {
                Console.WriteLine("我们超市有:" + item[0].Name+"\t"+"有"+item.Count+"个"+"\t"+ "每个" + item[0].Price+"元\n");
            }
        }
        //list[0]存Bee
        //list[1]存Note
        //list[2]存Apple
        //list[3]存Banana
        
        /// <summary>
        /// 创建仓库的时候添加货架
        /// </summary>
        public CuangKu()
        {
            list.Add(new List<Productfather>());
            list.Add(new List<Productfather>());
            list.Add(new List<Productfather>());
            list.Add(new List<Productfather>());
        }

        /// <summary>
        /// 进货
        /// </summary>
        /// <param name="strType">货物名称</param>
        /// <param name="count">进货数量</param>
        public void JinPros(string strType,int count)
        {
            for(int i=0;i<count;i++)
            {
                switch(strType)
                {
                    case "Bee":
                        list[0].Add(new Bee("蜂蜜",Guid.NewGuid().ToString(),5));
                        break;
                    case "Note":
                        list[1].Add(new Note("本子", Guid.NewGuid().ToString(), 2));
                        break;
                    case "Apple":
                        list[2].Add(new Apple("苹果", Guid.NewGuid().ToString(), 3));
                        break;
                    case "Banana":
                        list[3].Add(new Banana("香蕉", Guid.NewGuid().ToString(), 4));
                        break;
                }
            }
        }

        /// <summary>
        /// 取货
        /// </summary>
        /// <param name="strType">货物名称</param>
        /// <param name="count">取货数量</param>
        /// <returns></returns>
        public Productfather[] QuPros(string strType,int count)
        {
            Productfather[] pf = new Productfather[count];

            for(int i=0;i<count;i++)
            {
                switch(strType)
                {
                    case "Bee":
                        pf[i] = list[0][0];
                        list[0].RemoveAt(0);
                        break;
                    case "Note":
                        pf[i] = list[1][0];
                        list[1].RemoveAt(0);
                        break;
                    case "Apple":
                        pf[i] = list[2][0];
                        list[2].RemoveAt(0);
                        break;
                    case "Banana":
                        pf[i] = list[3][0];
                        list[3].RemoveAt(0);
                        break;
                }
            }

            return pf;
        }
    }
}
