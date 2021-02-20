using System;
using System.Collections.Generic;
using System.Text;

namespace 面向对象编程_继承
{
    class Enemy
    {
        private float hp;
        private float speed;

        public float HP
        {
            get
            {
                return hp;
            }
            set
            {
                hp = value;
            }
        }
        public float Speed
        {
            get
            {
                return speed;
            }
            set
            {
                speed = value;
            }
        }

        public void AI()
        {
            Console.WriteLine("这里是Enemy公有的AI方法");
        }
        //虚方法，使用情景比如敌人都有走路动作，但每个敌人走路的方式不一样
        public virtual void Move()
        {
            Console.WriteLine("这里是Enemy公有的Move方法");
        }
        public void Jump()
        {
            Console.WriteLine("这里是Enemy公有的Jump方法");
        }
    }
}
