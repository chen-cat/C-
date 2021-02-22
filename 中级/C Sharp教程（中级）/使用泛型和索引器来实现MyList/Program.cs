using System;

namespace 使用泛型和索引器来实现MyList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> array = new MyList<int>();
            array.Add(42);
            array.Add(22);
            array.Add(32);
            //array[0] = 8;
            array.Insert(1, 88);
            //array.RemoveAt(1);
            array.Sort();
            for (int i = 0; i < array.Count; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.ReadKey();
        } 
    }
}
