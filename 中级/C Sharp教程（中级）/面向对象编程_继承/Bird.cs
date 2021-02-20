using System;
using System.Collections.Generic;
using System.Text;

namespace 面向对象编程_继承
{
    abstract class Bird//如果类中有抽象函数，那么这个类一定要为抽象类
    {
        private float speed;

        public void Eat()
        {

        }
        //抽象函数：当父类的函数一定会被重写的时候可以使用
        public abstract void Fly();
    }
}
