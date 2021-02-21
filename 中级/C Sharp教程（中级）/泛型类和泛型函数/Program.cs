using System;

namespace 泛型类和泛型函数
{
    class Program
    {
        static void Main(string[] args)
        {
            var ca = new ClassA<int,string>(12,14);//当我们构造泛型类的时候，需要指定泛型类的类型
            Console.WriteLine(ca.GetSum());

            Console.WriteLine(GetSum(12, 34));
            Console.WriteLine(GetSum(1.2, 34));
            Console.WriteLine(GetSum("abc", "d"));

            Console.WriteLine(GetNum<int,string,bool>(12));//泛型函数只有一种泛型的时候可以系统系别，但2种或以上时需要定义类型

            Console.ReadKey();
        }
        public static string GetSum<T>(T a, T b)//泛型函数调用的时候指定类型
        {
            return a + "" + b;
        }
        public static T GetNum<T,T1,T2>(T a)//泛型函数也可定义多种泛型
        {
            return a;
        }
    }
}
