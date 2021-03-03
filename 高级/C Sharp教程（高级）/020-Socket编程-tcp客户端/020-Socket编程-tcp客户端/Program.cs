using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace _020_Socket编程_tcp客户端
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket tcpCilent = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress ipadress = IPAddress.Parse("10.18.19.232");//可以把一个字符串的ip地址转化为ipaddress的对象
            EndPoint point = new IPEndPoint(ipadress,7788);
            //发起建立连接的请求
            tcpCilent.Connect(point);//通过ip和端口定位连接上服务端
            Console.WriteLine("向服务器请求连接");

            byte[] data = new byte[1024];//声明一个byte的数组用于接收服务器传过来的数据，1024为字节容量
            int length =  tcpCilent.Receive(data);//返回接收到服务器数据的长度
            string message = Encoding.UTF8.GetString(data,0,length);//添加索引只把接收到的信息进行转换
            Console.WriteLine("接收到服务器的消息："+message);

            //向服务端发送信息
            Console.WriteLine("请向服务器发送一条信息");
            string message1 = Console.ReadLine();//接收用户输入的字符串
            tcpCilent.Send(Encoding.UTF8.GetBytes(message1));
            Console.WriteLine("向服务器发送了一条消息");
            Console.ReadKey();
        }
    }
}
