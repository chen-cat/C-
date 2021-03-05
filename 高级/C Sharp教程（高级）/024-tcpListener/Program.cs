using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace _024_tcpListener
{
    class Program
    {
        static void Main(string[] args)
        {
            //TcpListener对Socket进行了一层封装，这个类里面自己会去创建Socket对象
            TcpListener tcpListener = new TcpListener(IPAddress.Parse("10.18.19.232"), 7788);
            //2、开始监听
            tcpListener.Start();
            //3、等待客户端接入，返回接入的客户端
            TcpClient tcpClient = tcpListener.AcceptTcpClient();
            //4、取得客户端发送过来的消息，返回一个网络流
            NetworkStream stream = tcpClient.GetStream();
            //5、通过网络流读取数据
            byte[] data = new byte[1024];//声明储存数据的容器
            while (true)
            {
                int length = stream.Read(data, 0, 1024);//0代表存储数据到数组的开始索引，1024表示数组的最大索引，返回读取具体数据的长度
                //6、把存储在byte数组中的数据转换成字符串
                string message = Encoding.UTF8.GetString(data, 0, length);
                Console.WriteLine("接收到客户端的信息为：" + message);
            }

            //结束后释放资源
            tcpListener.Stop();//停止监听
            tcpClient.Close();
            stream.Close();

            Console.ReadKey();

        }
    }
}
