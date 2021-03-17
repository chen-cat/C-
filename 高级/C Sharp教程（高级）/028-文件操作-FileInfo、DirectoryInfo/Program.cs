using System;
using System.IO;

namespace _028_文件操作_FileInfo_DirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            //相对路径：就是找当前程序所在的路径
            FileInfo fileInfo = new FileInfo("TextFile1");
            Console.WriteLine(fileInfo.Exists);//判断文件是否存在

            //绝对路径：文件完整的路径名
            FileInfo fileInfo1 = new FileInfo(@"D:\C-\高级\C Sharp教程（高级）\027-文件操作-FileInfo\bin\Debug\netcoreapp3.1\TextFile1");
            Console.WriteLine(fileInfo1.Exists);

            FileInfo fileInfo2 = new FileInfo("s1.txt");
            if (fileInfo2.Exists == false)
            {
                fileInfo2.Create();//创建
            }

            fileInfo2.CopyTo("s2.txt");//复制

            //fileInfo2.Delete();//删除
            //文件夹的方法跟文件差不多
            DirectoryInfo directoryInfo = new DirectoryInfo("test");

            Console.ReadKey();
        }
    }
}
