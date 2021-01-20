using System;

namespace 百钱买百鸡
{
    class Program
    {
        static void Main(string[] args)
        {
            //解决百钱买百鸡的问题，某人100元，要买100只鸡，公鸡5元1只，母鸡3元1只，小鸡1元3只，问可以买到公鸡，母鸡，小鸡多少只，把所以可能打印出来。
            for (int i = 0; i <=100/5; i++)//公鸡最多可以买多少只
            {
                for (int j = 0; j <= (100 - 5 * i)/3; j++)
                {
                    int conut = (100 - 5 * i - 3 * j) * 3;
                    if (i+j+conut==100)
                    {
                        Console.WriteLine("公鸡有" + i + "母鸡有" + j + "小鸡有" + conut);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
