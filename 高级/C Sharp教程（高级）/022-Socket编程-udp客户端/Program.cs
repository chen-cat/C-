using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace _022_Socket编程_udp客户端
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket udpClient = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            while (true)
            {
                
                EndPoint serverPoint = new IPEndPoint(IPAddress.Parse("10.18.19.232"), 7788);//要发送过去的服务器
                string message = Console.ReadLine();
                byte[] data = Encoding.UTF8.GetBytes(message);
                udpClient.SendTo(data, serverPoint);
            }
            udpClient.Close();
            Console.ReadKey();
        }
    }
}
