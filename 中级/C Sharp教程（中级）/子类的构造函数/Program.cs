using System;

namespace 子类的构造函数
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass dr = new DerivedClass();
            DerivedClass dr1 = new DerivedClass(2,1);
            
            Console.ReadLine();
        }
    }
}
