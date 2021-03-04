using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;

namespace _021_聊天室_tcp服务器端
{
    class Program
    {
        static List<Client> clientList = new List<Client>();
        //广播消息给其他的客户端
        public static void BroadcastMessage(string message)
        {
            foreach (var item in clientList)
            {
                if (item.Connected)
                {
                    item.SendMessage(message);
                }
                else { clientList.Remove(item); }
            }
        }
        static void Main(string[] args)
        {
            Socket tcpServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            tcpServer.Bind(new IPEndPoint(IPAddress.Parse("10.18.19.232"), 7788));

            tcpServer.Listen(100);
            Console.WriteLine("开始监听");

            while (true)
            {
                Socket clientSocket =  tcpServer.Accept();
                Console.WriteLine("一个客户端连接上了");
                Client client = new Client(clientSocket);//把与客户端通信的逻辑（收发消息）放到client类里面进行处理
                clientList.Add(client);
            }

            Console.ReadKey();

        }
    }
}