using System;

namespace 面向对象编程_继承
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Boss boss = new Boss();
            boss.AI();//继承父类的所有的字段跟函数
            boss.Attack();//子类特有的函数*/

            Enemy enemy = new Boss();
            //父类声明的对象，可以使用子类去构造，子类声明的对象不可以使用父类构造
            //enemy虽然使用了父类声明，但是使用了子类构造，本质上还是一个子类类型，可以使用强制类型转换成子类类型,转换后可调用子类的函数
            Boss boss = (Boss)enemy;
            boss.Attack();
            enemy.Move();//调用的是boss重写后的move方法，因为enemy的类型是子类
            enemy.Jump();//调用的是父类的Jump方法，因为隐藏方法只是被隐藏了，本质上方法还是存在的，用谁声明对象就调用谁的方法
            boss.Jump();//调用子类的Jump方法


            //this关键字：1、可以访问当前类中所有的字段和方法 2、编译器提示，方便查看该类有哪些字段和方法 3、区别形参和实参
            //base关键字：只能调用父类的字段和方法
            Crow crow = new Crow();
            crow.Fly();

            Bird bird = new Crow();//可以通过抽象类声明对象，子类构造，不可以使用抽象类构造
            bird.Fly();

            Console.ReadLine();
        }
    }
}
