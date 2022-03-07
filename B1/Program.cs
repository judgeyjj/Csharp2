using System;
using System.Collections.Generic;

namespace B1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("请输入一个数：");
                int num = int.Parse(Console.ReadLine());
                if (num <= 1)
                {
                    Console.WriteLine("错误输入，该数小于或等于1");
                }
                else
                {
                    bool flag = false;
                    for (int i = 2; i < num; i++)
                    {
                        if (num % i == 0)
                        {
                            flag = true;
                            break;
                        }
                    }
                    if (flag)
                    {
                        string result = num + "=";
                        List<int> numList = new List<int> { };
                        int n = num;
                        while (n != 1)
                        {
                            for (int i = 2; i <= n; i++)
                            {
                                if (n % i == 0)
                                {
                                    n = n / i;
                                    numList.Add(i);
                                    break;
                                }
                            }
                        }
                        for (int i = 0; i < numList.Count; i++)
                        {
                            if (i == (numList.Count - 1))
                            {
                                result += numList[i];
                            }
                            else
                            {
                                result += numList[i] + "*";
                            }
                        }
                        Console.Write(result);
                    }
                    else
                    {
                        Console.WriteLine("该数是质数");
                    }
                }
                Console.ReadLine();
                Console.Clear();
            }
            Console.ReadLine();
        }
    }
}