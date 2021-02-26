using System;
using System.Collections.Generic;
using System.Text;

namespace _010_观察者模式
{
    class Cat
    {
        private string name;
        private string color;

        public Cat(string Name,string Color)
        {
            this.name = Name;
            this.color = Color;
        }

        public void catComing()
        {
            Console.WriteLine(color+"的"+name+"来了");
            if (actComing!= null)
            {
                actComing();
            }
        }
        //事件只能在自身的类中被调用，不能被外界调用，但可以在外界注册方法
        public event Action actComing;//委托是观察者模式，事件是发布订阅者模式
    }
}
