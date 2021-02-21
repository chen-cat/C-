using System;
using System.Collections.Generic;
using System.Text;

namespace 泛型类和泛型函数
{
    //泛型类
    class ClassA<T,A>//T代表一个数据类型,A也代表一种类型，可定义多种类型,构造的时候所有泛型都需要定义
    {
        private T a;
        private T b;
        private T c;

        public ClassA(T a,T b)
        {
            this.a = a;
            this.b = b;
        }

        public string GetSum()
        {
            return a +""+ b;//使用""把a+b转成字符串
        }
    }
}
