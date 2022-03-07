using System;
using System.Linq;//运用C#中数组自带的方法求最小值，最大值，平均值和总和

namespace B2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 4, 3, 0, -1, 34, 545, 2, 34 };
            Console.WriteLine("数组最小值:{0}", array.Min());
            Console.WriteLine("数组最大值:{0}", array.Max());
            Console.WriteLine("数组平均值:{0}", array.Average());
            Console.WriteLine("数组总和:{0}", array.Sum());
        }
    }
}
