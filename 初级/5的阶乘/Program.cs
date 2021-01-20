using System;

namespace _5的阶乘
{
    class Program
    {
        static void Main(string[] args)
        {
            //用递归的方式计算5的阶乘，5的阶乘拆分本质为f(n)= n*f(n-1)
            int JieCheng(int i)
            {
                if (i == 1) return 1;
                return i * JieCheng(i - 1);
            }
            Console.WriteLine(JieCheng(5));

            Console.ReadLine();
        }
    }
}
