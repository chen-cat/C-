using System;
using System.Collections.Generic;
using System.Text;

namespace 面向对象编程_定义类
{
    public class Vector3
    {
        //编程习惯上一般会把所有的字段设置成private,通过set方法去访问
        private float x, y, z;
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
