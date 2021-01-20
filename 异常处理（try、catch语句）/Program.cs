using System;

namespace 异常处理_try_catch语句_
{
    class Program
    {
        static void Main(string[] args)
        {
            //异常处理，利用try/catch语句捕捉异常
            Console.WriteLine("请输入一个整数");
            int num = 0;
            while (true)
            {
                try
                {
                    num = Convert.ToInt32(Console.ReadLine());//在try块中，如果有一行代码发生了异常，那么try块中后面的代码都不会执行了
                    break;
                }
                catch (Exception)
                {

                    Console.WriteLine("你输入的不是一个整数");
                }
            }
            Console.WriteLine("你输入的整数为：" + num);
            Console.ReadKey();
            //尝试上传git试试能否成功
        }
    }
}
