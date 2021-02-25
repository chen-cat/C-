using System;

namespace 匿名方法
{
    class Program
    {
        static int Method(int a,int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            int c = 5;
            //Func<int, int, int> plus = Method;
            //修改成匿名方法的形式
            //使用匿名方法的情景：1、只需要给一个委托，并不需要其他地方调用，可以减少代码量以及复杂性 2、回调参数
            Func<int, int, int> plus = delegate (int a, int b)
            {
                return a + b;
            };
            //lambda表达式是用来代替匿名方法的
            Func<int, int, int> plusB1 = (a,b) =>//第一种方式,参数a、b前不需要声明类型，因为Func<int, int, int>已经声明了
            {
                return a + b;
            };

            Func<int, int> plusB2 = a =>//第二种方式,如果只有一个参数，就不用加（）
            {
                return a;
            };

            Func<int, int> plusB3 = a => a;//第三种方式,当函数体的语句只有一句时，{}和return（可返回参数的委托）可以省略

            Func<int, int> plusB4 = a => a+c;//第四种方式,lambda表达式可以访问lambda表达式外部的变量，这是一个很好的功能，但是如果使用不正确会很危险
            Console.WriteLine(plusB4(5));
            c = 10;
            Console.WriteLine(plusB4(5));//这个方法的结果，不但受到参数的控制，还受到c变量的控制，如果c不小心被其他地方串改了，很容易出现问题

            Console.ReadKey();
        }
    }
}