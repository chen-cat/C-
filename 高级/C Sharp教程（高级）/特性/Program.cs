//#define IsText1//定义一个宏
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace 特性
{
    class Program
    {
        //[Obsolete]//Obsolete特性代表这个方法过时了
        [Obsolete("这个方法已过时，请使用NewMethod")]//（）可以接一句提示语，在调用这个方式时会显示这句话
        //[Obsolete("这个方法已过时，请使用NewMethod", true)]//ture代表禁用改方法
        static void OldMethod()
        {
            Console.WriteLine("这是一个旧方法");
        }
        static void NewMethod()
        {
            Console.WriteLine("这是一个新方法");
        }

        //定义方法的CIL代码本身总是会包含在程序集中，只是调用代码会被忽略
        [Conditional("IsText1")]//IsText1是宏的名字，Conditional可以让一段代码在不再被调用时，可以一键注销不运行，开关由宏控制。
        static void Text1()
        {
            Console.WriteLine("Text1");
        }
        static void Text2()
        {
            Console.WriteLine("Text2");
        }

        static void Method(string s, [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0,[CallerMemberName] string member = "")//调用者信息特性：1、[CallerFilePath]文件路径 2、[CallerLineNumber]调用代码行数 3、[CallerMemberName]调用成员的名称
        {
            Console.WriteLine(s);
            Console.WriteLine(filePath);//参数是由系统传递过来的
            Console.WriteLine(lineNumber);
            Console.WriteLine(member);
        }

        //在单步调试的时候，我们不希望调试器进入某些方法，可以[DebuggerStepThrough]特性来跳过调试
        //[DebuggerStepThrough]
        static void Method1()
        {
            Console.WriteLine("[DebuggerStepThrough]特性");
        }

        static void Main(string[] args)
        {
            OldMethod();

            Text1();
            Text2();
            Text1();
            Text1();

            Method("调用者信息特性");

            Method1();

            Console.ReadKey();
        }
    }
}
