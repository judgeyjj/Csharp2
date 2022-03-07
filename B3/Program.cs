using System;


namespace B3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i <= 100; i++)
            {
                bool b = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)     //根据质数判断的定义，只需判断到是不是它平方根的倍数
                {
                    if (i % j == 0)     //说明不是质数
                    {
                        b = false;
                        break;
                    }
                }
                if (b == true)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
