using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace _023_Socket_udp服务端
{
    class Program
    {
        private static Socket udpServer;
        static void Main(string[] args)
        {
            udpServer = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);//Dgram是数据报模式
            //绑定ip跟端口
            udpServer.Bind(new IPEndPoint(IPAddress.Parse("10.18.19.232"),7788));
            //利用线程来不断接收信息，设置后台线程是因为退出后线程也没必要继续执行了
            new Thread(ReceiveMessage) { IsBackground = true }.Start();

            //udpServer.Close();
            Console.ReadKey();
        }

        static void ReceiveMessage()
        {
            while (true)
            {
                EndPoint remoteEndPoint = new IPEndPoint(IPAddress.Any, 0);
                byte[] data = new byte[1024];
                //.ReceiveFrom会暂停等待，有数据传过来的时候才会执行下面的代码
                int length = udpServer.ReceiveFrom(data, ref remoteEndPoint);//ref代表后面可以修改这个参数，因为目前这个参数的ip跟端口没有指定,客户端的端口由系统自动分配
                string message = Encoding.UTF8.GetString(data, 0, length);
                Console.WriteLine("收到来自ip:" + (remoteEndPoint as IPEndPoint).Address.ToString() + (remoteEndPoint as IPEndPoint).Port + "的消息" + message);
            }
        }
    }
}
