using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace _021_聊天室_tcp服务器端
{
    //用来跟客户端做通信
    class Client
    {
        private Socket clientSocket;
        private Thread thread;

        private byte[] data = new byte[1024];//定义一个用于接收数据的容器

        public Client(Socket s)
        {
            clientSocket = s;
            //启动一个线程，处理客户端的数据接收
            thread = new Thread(ReceiveMessage);
            thread.Start();
        }

        private  void ReceiveMessage()
        {
            //需要不停的接收客户端的信息
            while (true)
            {
                if (clientSocket.Poll(10, SelectMode.SelectRead))
                {
                    clientSocket.Close();
                    break;//跳出循环，终止线程
                }
                int length = clientSocket.Receive(data);
                string message = Encoding.UTF8.GetString(data,0,length);
                //把接收到的数据分发到其他的客户端
                Program.BroadcastMessage(message);
                Console.WriteLine("接收到客户端发来的消息：" + message);
            }
        }
        //发送消息
        public void SendMessage(string message)
        {
            byte[] data = Encoding.UTF8.GetBytes(message);
            clientSocket.Send(data);
        }
        //提供一个属性判断客户端是否连接
        public  bool Connected
        {
            get { return clientSocket.Connected; }
        }
    }
}
