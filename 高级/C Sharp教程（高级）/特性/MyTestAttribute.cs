using System;
using System.Collections.Generic;
using System.Text;

namespace 特性
{
    //1、特性类的后缀以Attribute结尾
    //2、需要继承自System.Attribute
    //3、一般情况下声明为sealed，不能被其他类继承
    //4、一般情况下特性类用来表示目标结构的一些状态（定义一些字段或者属性，一般不定义方法）
    [AttributeUsage(AttributeTargets.Class)]//该特性表示这个特性类可以应用到程序的结构有哪些（类、字段或者方法）
    sealed class MyTestAttribute:System.Attribute{
        public string Description { get; set; }
        public string Versionption { get; set; }
        public int ID { get; set; }

        public MyTestAttribute(string des)
        {
            this.Description = des;
        }
    }
}
