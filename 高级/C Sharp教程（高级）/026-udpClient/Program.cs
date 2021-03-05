using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace _026_udpClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建UdpClient 绑定ip跟端口
            UdpClient udpClient = new UdpClient(new IPEndPoint(IPAddress.Parse("10.18.19.232"), 7788));
            while (true)
            {
                //接收数据
                IPEndPoint point = new IPEndPoint(IPAddress.Any, 0);
                byte[] data = udpClient.Receive(ref point);//通过point确定消息是来自哪个客户端的
                string message = Encoding.UTF8.GetString(data);
                Console.WriteLine("接收到的消息为：" + message);
            }
            udpClient.Close();

            Console.ReadKey();
        }
    }
}
