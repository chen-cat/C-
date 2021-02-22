using System;
using System.Collections.Generic;
using System.Text;

namespace 使用泛型和索引器来实现MyList
{
    class MyList<T> where T:IComparable//调用.CompareTo方法来比较大小
    {
        private T[] array;
        private int count = 0;//定义列表元素的子段

        //提供有参构造函数初始化列表的容量
        public MyList(int size)//size为集合的初始容量
        {
            if (size >= 0)
            {
                array = new T[size];
            }
        }
        //提供无参构造函数初始化泛型数组array
        public MyList()
        {
            array = new T[0];
        }
        //定义列表容量的子段
        public int Capacity {
            get
            {
                return array.Length;
            }
        }
        //通过get方法让外部访问count
        public int Count
        {
            get
            {
                return count;
            }
        }
        //列表添加元素的方法
        public void Add(T item)
        {
            if (count==Capacity)//元素个数与容量相等，再添加元素的话就需要扩大2倍的容量
            {
                if (Capacity == 0)
                {
                    array = new T[4];//初始容量默认设置为4个
                }
                else
                {
                    var newArray = new T[Capacity * 2];//创建一个新的2倍容量的数组
                    Array.Copy(array, newArray, count);//利用数组的copy函数，把旧数组的元素复制到2倍容量的新数组
                    array = newArray;//扩充容量完成
                }
            }
            array[count] = item;
            count++;
        }
        //获得元素的方法
        public T GetItem(int index)
        {
            if (index>=0&&index<count)
            {
                return array[index];
            }
            else
            {
                throw new Exception("索引超出了范围");//抛出异常
            }
        }
        //创建列表的索引器MyList[index],其本质是属性
        public T this[int index]
        {
            get { return GetItem(index); }
            set {
                if (index >= 0 && index < count)
                {
                    array[index] = value;
                }
                else
                {
                    throw new Exception("索引超出了范围");//抛出异常
                }
            }
        }
        //列表的插入方法
        public void Insert(int index,T item)
        {
            if (index>=0&&index<count)
            {
                if (Count == Capacity)
                {
                    var newArray = new T[Capacity * 2];//创建一个新的2倍容量的数组
                    Array.Copy(array, newArray, count);//利用数组的copy函数，把旧数组的元素复制到2倍容量的新数组
                    array = newArray;//扩充容量完成
                }
                for (int i = count-1; i >=index; i--)
                {
                    array[i + 1] = array[i];//元素向后移动
                }
                array[index] = item;
                count++;
            }
            else
            {
                throw new Exception("索引超出了范围");//抛出异常
            }
        }
        //列表的移除方法
        public void RemoveAt(int index)
        {
            if (index >= 0 && index < count)
            {
                for (int i = index+1; i < count; i++)
                {
                    array[i - 1] = array[i];//元素向前移
                }
                count--;
            }
            else
            {
                throw new Exception("索引超出了范围");//抛出异常
            }
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < count; i++)
            {
                if (array[i].Equals(item))//由于item是泛型T，这里不能用==来判断，.Equals方法可以用作判断是否相等
                {
                    return i;
                }
            }
            return -1;
        }
        public int LastIndexOf(T item)
        {
            for (int i = count-1; i >=0; i--)
            {
                if (array[i].Equals(item))//由于item是泛型T，这里不能用==来判断，.Equals方法可以用作判断是否相等
                {
                    return i;
                }
            }
            return -1;
        }
        //升序
        public void Sort()
        {
            //冒泡排序
            for (int j = 0; j < count; j++)
            {
                for (int i = 0; i < count - 1-j; i++)
                {
                    if (array[i].CompareTo(array[i + 1]) > 0)//由于array是泛型T，不能通过array[i]>array[i+1]比较大小，可以使用.CompareTo方法来比较大小，返回的值大于0，即前面的大于后面的
                    {
                        T item = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = item;
                    }
                }
            }
        }
    }
}