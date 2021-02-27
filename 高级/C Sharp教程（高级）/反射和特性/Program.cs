using System;
using System.Reflection;

namespace 反射和特性
{
    class Program
    {
        static void Main(string[] args)
        {
            //每一个类对于一个type对象，这个type对象存储了这个类有哪些方法、数据、成员等
            MyClass mc = new MyClass();//一个类的数据是存储在对象中的，但是type对象只存储类的成员
            Type type =  mc.GetType();//通过对象获取其所属类的Type对象

            Console.WriteLine(type.Name);//获取类名
            Console.WriteLine(type.Namespace);//获取所在的命名空间
            Console.WriteLine(type.Assembly);//获取程序集
            //获取所有字段（成员）
            FieldInfo[] array1 =  type.GetFields();//只能获取public字段
            foreach (FieldInfo item in array1)
            {
                Console.Write(item.Name+" ");
            }
            //获取所有属性
            PropertyInfo[] array2 = type.GetProperties();
            foreach (PropertyInfo item in array2)
            {
                Console.Write(item.Name + " ");
            }
            //获取所有方法
            MethodInfo[] array3 = type.GetMethods();
            foreach (MethodInfo item in array3)
            {
                Console.Write(item.Name + " ");
            }
            //通过type对象可以获取它对应的类的所有成员（public）

            //程序集
            MyClass mc1 = new MyClass();
            Assembly assembly = mc1.GetType().Assembly;
            Console.Write(assembly.FullName);
            Type[] types = assembly.GetTypes();//获取这个程序集所有的type
            foreach (var item in types)
            {
                Console.Write(item);
            }
            Console.ReadKey();
        }
    }
}
