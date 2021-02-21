using System;

namespace 练习题
{
    class Program
    {
        abstract class BaseClass{
            public virtual void MethodA()
            {
                Console.WriteLine("BaseClass");
            }
            public virtual void MethodB() {
                Console.WriteLine("BaseClass_B");
            }
        }

        class Class1 : BaseClass
        {
            public void MethodA()//如果一个虚方法，在子类中没有通过override关键字，那么这个方法没有被重写，只是被隐藏了
            {
                Console.WriteLine("Class1");
            }
            public override void MethodB(){
                Console.WriteLine("Class1_B");
            }
        }

        class Class2 : Class1
        {
            new public void MethodB() {
                Console.WriteLine("Class2_B");
            }
        }

        class MainClass
        {
            public static void Main(string[] args)
            {
                Class2 c2 = new Class2();
                Class1 c1 = new Class1();
                BaseClass bs = c1;//父类声明，class1构造
                c1.MethodA();
                bs.MethodA();//输出"BaseClass"
                c2.MethodA();//输出"Class1"

                Class1 c1_1 = c2;
                BaseClass bs_1 = c2;
                c1_1.MethodB();//输出"Class1_B"
                bs_1.MethodB();//输出"Class1_B"
                Console.ReadKey();
            }
        }
    }
}
