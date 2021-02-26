using System;
using System.Collections.Generic;
using System.Text;

namespace _010_观察者模式
{
    class Mouse
    {
        private string name;
        private string color;

        public Mouse(string Name, string Color,Cat cat)
        {
            this.name = Name;
            this.color = Color;
            cat.actComing += mouseRun;
        }
        
        public void mouseRun()
        {
            Console.WriteLine("猫来了，"+color + "的" + name + "飞快的跑了！");
        }
    }
}
