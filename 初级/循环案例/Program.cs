using System;

namespace 循环案例
{
    class Program
    {
        static void Main(string[] args)
        {
            //有关系式1*1+2*2+...+k*k<2000,求K的最大值
            int sum = 0;
            int index = 0;
            do
            {
                index++;
                sum = index * index + sum;
            } while (sum<2000);
            Console.WriteLine(index-1);

            Console.ReadLine();
        }
    }
}
