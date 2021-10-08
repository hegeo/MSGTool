using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkerServer
{
    class Server
    {
        public void basicServer()
        {
            //监听端口
            IPEndPoint udpPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 5500);
            UdpClient udpClient = new UdpClient(udpPoint);
            IPEndPoint senderPoint = new IPEndPoint(IPAddress.Any, 0);
            try
            {
                while (true)
                {
                    byte[] bytes = udpClient.Receive(ref senderPoint);
                    string strIP = "信息来自" + senderPoint.Address.ToString();
                    string strInfo = Encoding.GetEncoding("gb2312").GetString(bytes, 0, bytes.Length);
                    MessageBox.Show(strInfo, strIP);

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }


        }



        public static void sender()
        {
            IPEndPoint udpPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 4505);
            UdpClient udpClient = new UdpClient(udpPoint);
            //UdpClient udpClient = new UdpClient();
            string sendMsg = "欢迎使用MSGServer";
            byte[] sendData = Encoding.Default.GetBytes(sendMsg);
            IPEndPoint targetPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 5500);
            udpClient.Send(sendData, sendData.Length, targetPoint);
            Console.WriteLine("Send Message:{0}", sendMsg);
            Console.Read();
        }
        public static void rever()
        {
            IPEndPoint udpPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 5500);
            UdpClient udpClient = new UdpClient(udpPoint);
            //IPEndPoint senderPoint = new IPEndPoint(IPAddress.Parse("14.55.36.2"), 0);
            IPEndPoint senderPoint = new IPEndPoint(IPAddress.Any, 0);
            byte[] recvData = udpClient.Receive(ref senderPoint);
            Console.WriteLine("Receive Message:{0}", Encoding.Default.GetString(recvData));
            Console.Read();
        }
    }
}
