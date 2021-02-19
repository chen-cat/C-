using System;
using System.Collections.Generic;
using System.Text;

namespace 面向对象编程_定义类
{
    public class Vector3
    {
        /*构造函数就是用于初始化数据的函数，当我们没有写任何构造函数的时候，系统编译器会提供一个默认的函数给我们
         *当我们使用new关键字创建类的时候，就会调用构造方法
         *声明基本的构造函数的语法就是声明一个和所在类同名的方法
         */
        public Vector3(float x,float y,float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            length = Length();
            Console.WriteLine("顾客的距离为："+length);
        }
        //编程习惯上一般会把所有的字段设置成private,通过set方法去访问
        private float x, y, z,length;

        //属性的定义和作用
        public float X
        {
            set
            {
                //通过set方法，在设置值之前可以做一些判断，字段就无法做判断(作用1)
                if (value>=0)
                {
                    x = value;
                }
                Console.WriteLine("属性中set块被调用");
            }
            //使用private设置属性的只读或者只写（作用2）
            private get
            {
                Console.WriteLine("属性中get块被调用");
                return x;
            }
        }

        public string Name { get; set; }//这里我们没有定义字段name，但编译器会自动给我们提供一个字段来存储name

        //public float x, y, z;
        //如果我们直接在方法内部访问同名变量的时候，优先访问最近的（也就是行参）
        //我们可以通过this.表示访问的是类的字段或方法
        public void SetX(float x)
        {
            this.x = x;
        }
        public void SetY(float y)
        {
            this.y = y;
        }
        public void SetZ(float z)
        {
            this.z = z;
        }

        public float Length()
        {
            return (float)Math.Sqrt(x * x + y * y + z * z);
        }
    }
}
