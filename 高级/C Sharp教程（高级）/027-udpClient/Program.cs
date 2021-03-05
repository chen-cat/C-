using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace _027_udpClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建客户端
            UdpClient client = new UdpClient();

            while (true)
            {
                string message = Console.ReadLine();
                byte[] data = Encoding.UTF8.GetBytes(message);
                //发送到哪个服务器
                client.Send(data, data.Length, new IPEndPoint(IPAddress.Parse("10.18.19.232"), 7788));
            }

            client.Close();
            Console.ReadKey();
        }
    }
}
