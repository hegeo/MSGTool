using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSGTool
{
    public partial class MainForm : Form
    {
        private Thread listenThread;
        private int listate,hwstate;
        private Point downPoint;
        private UdpClient udpClient;
        private Random r = new Random();
        private string serverIP,serverPort;

        public MainForm()
        {
            InitializeComponent();
            listate = 0; hwstate = 0;
            this.idlabel.Text = r.Next(1000, 10000).ToString();
           
            listenThread = new Thread(MSGlistener);
            listenThread.IsBackground = true;
        }

        private void MSGlistener()
        {
            GifRichTextBox transrtf = new MSGTool.GifRichTextBox();
            try
            {
                IPEndPoint udpPoint = new IPEndPoint(IPAddress.Any, Convert.ToInt32(idlabel.Text));
                udpClient = new UdpClient(udpPoint);
                IPEndPoint listenerPoint = new IPEndPoint(IPAddress.Any, 0);
                this.Invoke((MethodInvoker)delegate
                {
                    receiveip.Clear();
                    receiveport.Clear();
                    receivemsg.Clear();
                }
                );
                button_connect.BaseColor = Color.FromArgb(247, 76, 49); button_connect.MouseBaseColor = Color.LightCoral; button_connect.DownBaseColor = Color.Salmon;
            while (true)
            {
                byte[] bytes = udpClient.Receive(ref listenerPoint);
                string strIP = listenerPoint.Address.ToString();
                string strPort = listenerPoint.Port.ToString();
                string strInfo = Encoding.GetEncoding("gb2312").GetString(bytes, 0, bytes.Length);
                transrtf.Rtf = strInfo; string strIext = transrtf.Text.ToString();
                if (strIext.Contains("@L@I@N@K:"))
                {
                    string[] sArray = Regex.Split(strIext, ":", RegexOptions.IgnoreCase);
                      this.Invoke((MethodInvoker)delegate
                      {
                         targetip.Text = sArray[1];
                         targetport.Text = sArray[2];
                         inputmsg.Text = idlabel.Text + "已和你连接";
                         MSGsender(inputmsg.Rtf);
                         MSGsender(inputmsg.Rtf);
                         inputmsg.Clear();
                      });
                }
                    this.Invoke((MethodInvoker)delegate
                    {
                        receiveip.Text = strIP;
                        receiveport.Text = strPort;
                        receivemsg.Rtf = (strInfo);
                        receivemsg.Focus();
                    });
                }
                    Thread.Sleep(100);

                }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void MSGsender(string sendMsg)
        {
            
            try
            {
                IPEndPoint targetPoint = new IPEndPoint(IPAddress.Parse(targetip.Text.ToString()), Convert.ToInt32(targetport.Text));
                byte[] sendData = Encoding.Default.GetBytes(sendMsg);
                udpClient.Send(sendData, sendData.Length, targetPoint);
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void skinButton5_Click(object sender, EventArgs e)
        {
            if (listate == 1)
            {
                MSGsender(inputmsg.Rtf);
                inputmsg.Clear();
            }
            else { }
            
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            if (listate == 1)
            {
                targetip.Text = serverIP;
                targetport.Text = serverPort;
                inputmsg.Clear();
                inputmsg.Text = "LINK:";
                receivemsg.Clear();
                inputmsg.Focus();
                inputmsg.Select(inputmsg.Text.Length, 0);
            }
            else 
            { }

        }

        private void skinButton2_Click(object sender, EventArgs e)
        {
            if (targetip.Text == "目标IP" || targetport.Text == "端口")
            {
                MessageBox.Show("ℹ请输入目标IP和端口");
            }
            else 
            {
                if (listate == 0)
                {
                    serverIP = targetip.Text.ToString();
                    serverPort = targetport.Text.ToString();
                    listenThread.Start();
                    listate = 1;
                    button_connect.Text = "重启";

                }
                else
                {
                    MSGsender("LOUT:" + idlabel.Text.ToString());
                    button_connect.BaseColor = Color.DodgerBlue; button_connect.MouseBaseColor = Color.SkyBlue; button_connect.DownBaseColor = Color.LightSkyBlue;
                    System.Diagnostics.Process.Start(System.Reflection.Assembly.GetExecutingAssembly().Location);
                }
                
            }

            
        }

        private void UDPForm1_MouseDown(object sender, MouseEventArgs e)
        {
            downPoint = new Point(e.X, e.Y);
        }

        private void UDPForm1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - downPoint.X,
                    this.Location.Y + e.Y - downPoint.Y);
            }
        }

        private void UDPForm1_Load(object sender, EventArgs e)
        {

        }

        private void label5_MouseClick(object sender, MouseEventArgs e)
        {
            if (hwstate == 0) { this.Size = new Size(524, this.Size.Height); helplabel.Text = "隐藏帮助"; hwstate = 1; }
            else { this.Size = new Size(255, this.Size.Height); helplabel.Text = "帮助信息"; hwstate = 0; }
           
        }

        private void rich_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Delete) || (e.KeyCode == Keys.Back))
            {
                this.Focus();
                inputmsg.Focus();
               
            }
        }

        private void skinButton3_Click(object sender, EventArgs e)
        {
            inputmsg.AddFile(@"C:\Temp\0.gif");
            inputmsg.Focus();
        }

        private void msg_VScroll(object sender, EventArgs e)
        {
            this.Focus();
            inputmsg.Focus();
               
        }

        private void skinButton4_Click(object sender, EventArgs e)
        {
            if (listate == 1)
            {
                targetip.Text = serverIP;
                targetport.Text = serverPort;
                inputmsg.Text = "LIST";
                MSGsender(inputmsg.Rtf);
                inputmsg.Clear();
            }
            else { }
        }

        private void skinButton7_Click(object sender, EventArgs e)
        {
            if (listate == 1)
            {
                targetip.Text = serverIP;
                targetport.Text = serverPort;
                inputmsg.Text = "LOGN:" + idlabel.Text.ToString();
                MSGsender(inputmsg.Rtf);
                inputmsg.Text = "HOME";
                MSGsender(inputmsg.Rtf);
                inputmsg.Clear();
            }
            else { }

        }

    }
}
