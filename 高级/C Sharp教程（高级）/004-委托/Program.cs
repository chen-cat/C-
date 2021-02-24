using System;

namespace _004_委托
{
    class Program
    {
        private delegate string GetAString();//定义委托

        private delegate void PrintString();
        static void PrintStr(PrintString print)//委托可以作为一个参数进行传递
        {
            print();
        }

        static void Method1()
        {
            Console.WriteLine("输出方法1");
        }
        static void Method2()
        {
            Console.WriteLine("输出方法2");
        }

        static void Main(string[] args)
        {
            int i = 40;

            //使用正常方法转行类型
            string a = i.ToString();//通过ToString方法转换成字符串类型
            Console.WriteLine(a);

            //使用委托转行类型
            //GetAString b = new GetAString(i.ToString);//委托初始化注册方法的第一种方式
            GetAString b = i.ToString;////委托初始化注册方法的第二种方式，常用的方式
            string s = b();

            PrintString method = Method1;
            PrintStr(method);
            method = Method2;
            PrintStr(method);

            Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}
