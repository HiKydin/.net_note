using System;
using System.Collections.Generic;

namespace _18List泛型集合
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.AddRange(new int[] { 1,23,4,56,7});
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
