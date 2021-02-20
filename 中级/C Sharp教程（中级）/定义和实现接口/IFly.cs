using System;
using System.Collections.Generic;
using System.Text;

namespace 定义和实现接口
{
    interface IFly//interface关键字定义接口，1、接口中的函数不允许提供结构体 2、接口不能有构造函数，也不能了有字段
                 //3、接口不允许运算符重载 4、不允许声明成员的修饰符，默认其成员都是共有的 5、类只能继承一个，接口可以实现多个
    {
        void Fly();
        void Eat();
    }
}
