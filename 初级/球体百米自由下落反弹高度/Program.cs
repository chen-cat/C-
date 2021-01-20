using System;

namespace 球体百米自由下落反弹高度
{
    class Program
    {
        static void Main(string[] args)
        {
            //一个球从100米高度自由落下，每次落地后反跳回原高度的一半，在落下，求它在第十次落地时，共经过多少米？第十次反弹多高？
            float height = 100;
            float distance = 0;
            for (int i = 1; i < 10; i++)
            {
                distance += height;
                height /= 2;
                distance += height;
            }
            distance += height;

            Console.WriteLine("共经过" + distance+"第十次反弹"+height) ;

            Console.ReadLine();
        }
    }
}
