using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class ChatManger : MonoBehaviour {

    public string ipaddress = "10.18.19.232";
    public int port = 7788;
    public InputField inputField;
    public Text recordText;

    private Thread t;
    private Socket clientSocket;
    private byte[] data = new byte[1024];//容器
    private string message = "";//用于接收服务器的消息
    // Start is called before the first frame update
    void Start()
    {
        ConnectToServer();
    }

    // Update is called once per frame
    void Update()
    {
        if (message!=null&&message!="")
        {
            recordText.text += "\n" + message;
            message = "";//清空消息
        }
    }

    void ConnectToServer()
    {
        clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        //跟客户端连接
        clientSocket.Connect(new IPEndPoint(IPAddress.Parse(ipaddress),port));
        //开启一个线程接收服务器的消息
        t = new Thread(ReceiveMessage);
        t.Start();
    }
    //线程的方法，用于不断接收消息
    void ReceiveMessage()
    {
        while (true)
        {
            if (clientSocket.Connected == false)
                break;
            int length = clientSocket.Receive(data);
            message = Encoding.UTF8.GetString(data, 0, length);
            //recordText.text = "\n"+message;//Unity里面的线程不允许直接操控其控件
        }
    }

    //客户端发送消息
    void SendMessage(string s)
    {
        byte[] data = Encoding.UTF8.GetBytes(s);
        clientSocket.Send(data);
    }

    public void OnButtonClick()
    {
        string message = inputField.text;
        SendMessage(message);
        inputField.text = "";
        Debug.Log(message);
    }

    void OnDisable()
    {
        clientSocket.Shutdown(SocketShutdown.Both);//关闭接收和发送
        clientSocket.Close();//关闭连接
        Debug.Log("关闭客户端");
    }
}
