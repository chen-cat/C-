using System;

namespace 面向对象编程_定义类
{
    class Program
    {
        static void Main(string[] args)
        {
            //如果要使用一个类，要先引入它所在的命名空间（namespace所指向的），由于我们这里定义的Custormer类跟这里的命名空间一致，所以可以直接使用
            Customer customer1;//声明一个对象
            customer1 = new Customer();//初始化对象
            customer1.name = "阿澈是子由";//我们自己定义的类声明的对象，要先初始化才能使用
            customer1.show();

            Vector3 v1;
            v1 = new Vector3(2,2,2);
            //使用构造函数后可以不使用set方法
            /*v1.SetX(2);
            v1.SetY(2);
            v1.SetZ(2);
            Console.WriteLine(v1.Length());*/
            Console.ReadLine();
        }
    }
}
