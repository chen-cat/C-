using System;

namespace _006_升级版冒泡排序
{
    class Program
    {
        static void Sort(int[] array)
        {
            bool isCertain = true;
            int count = 0;
            do
            {
                isCertain = false;
                for (int i = 0; i < array.Length-1; i++)
                {
                    if (array[i]>array[i+1])
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        count++;
                        isCertain = true;
                    }
                }
            } while (isCertain);
            Console.WriteLine(count);
        }

        static void Main(string[] args)
        {
            int[] sortArray = new int[] { 23, 34, 12, 18};
            Sort(sortArray);
            for (int i = 0; i < sortArray.Length; i++)
            {
                Console.Write(sortArray[i] + " ");
            }

            Employee[] e = new Employee[]
            {
                new Employee("abc",123),
                new Employee("abb",113),
                new Employee("bbc",23),
                new Employee("rbc",13),
                new Employee("mnc",143),
                new Employee("gf",8),
            };
            CommonSort(e, Employee.Compare);
            foreach (var item in e)
            {
                Console.WriteLine(item.ToString());//需要重写.ToString方法，在Employee类中
            }

            Console.ReadKey();
        }

        static void CommonSort<T>(T[] sortArray,Func<T,T,bool> compareMethod)//利用泛型声明一个数组参数，一个委托参数，数组参数为Employee类型的数组，委托为系统自带的有返回值的Func，调用CommonSort方法的时候，可以把Employee中的比较方法注册进来
        {
            bool isCertain = true;
            do
            {
                isCertain = false;
                for (int i = 0; i < sortArray.Length - 1; i++)
                {
                    if (compareMethod(sortArray[i],sortArray[i+1]))//利用委托注册进来的方法做比较
                    {
                        T temp = sortArray[i];
                        sortArray[i] = sortArray[i + 1];
                        sortArray[i + 1] = temp;
                        isCertain = true;
                    }
                }
            } while (isCertain);
        }
    }
}
