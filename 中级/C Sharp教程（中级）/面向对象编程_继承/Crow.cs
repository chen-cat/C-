using System;
using System.Collections.Generic;
using System.Text;

namespace 面向对象编程_继承
{
    class Crow : Bird//当我们继承一个抽象类的时候，必须实现抽象类中的抽象函数
    {
        public override void Fly()
        {
            Console.WriteLine("实现父类的抽象函数");
        }
    }
}
