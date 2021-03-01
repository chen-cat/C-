using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _015_线程_通过Thread发起线程
{
    class MyThread
    {
        private string filename;
        private string filepath;

        public MyThread(string filename,string filepath){
            this.filename = filename;
            this.filepath = filepath;
        }

        public void DownFile()
        {
            Console.WriteLine("开始下载："  + filename);
            Thread.Sleep(1000);
            Console.WriteLine("下载完成。" + filepath);
        }
    }
}
