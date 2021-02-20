using System;
using System.Collections.Generic;
using System.Text;

namespace 面向对象编程_继承
{
    class Boss:Enemy
    {
        public void Attack()
        {
            Console.WriteLine("Boss正在攻击");
        }
        //虚方法重写
        public override void Move()
        {
            Console.WriteLine("Boss正在移动");
        }
        //隐藏父类的同名函数
        public new void Jump()
        {
            Console.WriteLine("Boss正在跳跃");
        }
        
    }
}
