using System;
using System.Net.Sockets;
using System.Text;

namespace _025_tcpClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //当我们创建TcpClient对象的时候，就会跟setver去建立连接
            TcpClient tcpClient = new TcpClient(("10.18.19.232"), 7788);
            //通过网络流进行数据的交换
            NetworkStream stream = tcpClient.GetStream();
            //通过网络流的Write进行发送数据
            while (true)
            {
                string message = Console.ReadLine();
                byte[] data = Encoding.UTF8.GetBytes(message);
                stream.Write(data, 0, data.Length);
            }

            tcpClient.Close();
            stream.Close();
            Console.ReadKey();
        }
    }
}
