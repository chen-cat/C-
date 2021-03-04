using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace _019_Socket编程_tcp服务器端
{
    class Program
    {
        //tcp保证数据正确性，udp可能丢包；tcp保证数据顺序,udp不保证
        static void Main(string[] args)
        {
            //创建Socket
            Socket tcpServer = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);//Stream是流模式
            //地址用byte类型
            IPAddress ipadress = new IPAddress(new byte[] { 10,18,19,232 });
            //IPEndPoint需要传入地址和端口。地址可以理解为连接设备（电脑），端口可以理解为连接软件
            EndPoint point  = new IPEndPoint(ipadress,7788);//EndPoint实际是一个抽象类；IPEndPoint是实现这个抽象类的，是对ip和端口做了一层封装的类
            //绑定ip和端口号
            tcpServer.Bind(point);//向操作系统申请一个可用的ip跟端口号，用来做通信
            //开始监听，等待客户端连接
            tcpServer.Listen(100);//100表示客户端最大连接数
            Console.WriteLine("开始监听");

            //使用Accept返回的socket跟客户端做通信
            Socket clientServer =  tcpServer.Accept();//暂停当前线程，直到有一个客户端连接进来，再开始下面的代码
            Console.WriteLine("一个客户端连接上了");

            string message = "连接成功";
            byte[] data =  Encoding.UTF8.GetBytes(message);//对字符串做编码，得到一个字符串的字节数组
            clientServer.Send(data);//输入一个字符串的信息
            Console.WriteLine("向客户端发送消息");

            //接收客户端发送的消息
            byte[] data1 = new byte[1024];//创建一个储存客户端信息的byte数组
            int length = clientServer.Receive(data1);
            string message1 = Encoding.UTF8.GetString(data1, 0, length);
            Console.WriteLine("接收到客户端发送过来的消息："+message1);

            Console.ReadKey();
        }
    }
}
