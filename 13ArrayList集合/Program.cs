using System;
using System.Collections;

namespace _13ArrayList集合
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(true);
            list.Add(1);
            list.Add('男');
            list.Add("张三");
            
            //添加多个元素
            list.AddRange(new int[] { 1, 2, 3, 4, 5 });
            list.AddRange(list);


            //list.Clear(); 清空所有元素
            //list.Remove('男') 删除单个元素
            //list.RemoveAt(0) 按下标删除对应元素
            //list.RemoveRange(0,3)根据下标删除一段元素
            //list.Sort() 升序排列
            //list.Reverse();反转
            //list.Insert(1, "插入的"); 在指定的位置插入一个元素
            //list.InsertRange(0, new string[] { "666", "241241" }); 在指定的位置插入一个集合
            bool b = list.Contains('男');//判断list中是否有指定元素
            Console.WriteLine(b);
            for (int i = 0; i < list.Count; i++)
            {
                //Console.WriteLine(list[i]);
            }

            //count 表示这个集合中实际包含的元素的个数
            //capcity 表示这个集合中可以包含的元素的个数
            Console.WriteLine(list.Count);
            Console.WriteLine(list.Capacity);
            //ArrayList集合的长度问题
            //每次集合中实际包含的元素个数count超过了可以包含的元素的个数capcity的时候
            //集合就会向内存中申请多开辟一倍的空间，来保证集合的长度一直够用

        }
    }
}
