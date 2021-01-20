using System;

namespace 递归调用
{
    class Program
    {
        static void Main(string[] args)
        {
            //f(n) = f(n-1)+f(n-2),f(0) = 2,f(1)=3,求f(40)递归调用
            int DiGui(int i) {
                if (i == 0) return 2;
                if (i == 1) return 3;
                return DiGui(i - 1) + DiGui(i - 2);
            }
            Console.WriteLine(DiGui(40));

            Console.ReadLine();
        }
    }
}
