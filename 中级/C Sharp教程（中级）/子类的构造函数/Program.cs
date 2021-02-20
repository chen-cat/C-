using System;

namespace 子类的构造函数
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass bc = new BaseClass();
            //bc.a = 100;//当我们构造对象的时候，对象中只包含了普通的字段，不包含静态字段
            bc.b = 100;

            BaseClass.a = 100;//静态字段只能通过类名的方式访问
        }
    }
}
