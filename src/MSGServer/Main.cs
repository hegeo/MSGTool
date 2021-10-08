using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Management;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Data;
using System.Text.RegularExpressions;
using System.IO;

namespace LinkerServer
{
    public partial class Main : Form
    {
        Point downPoint;
        private Point mouseOffset;
        private bool isMouseDown = false;
        private DataTable userTable = new DataTable();

        private double[] cpuArray = new double[30];
        private double[] ramArray = new double[30];
        private double[] ioArray = new double[30];
        private double[] netArray = new double[30];

        public int state = 1;
        public long qt = 0;
        public long run = 0;
        public int zx = 0;
        public int zg = 0;
        public int ram;
        public string cpu,os,aram;
        public string hostip = "127.0.0.1";
        public int hostport = 5500;

        public enum WMIPath
        {
            // 硬件
            Win32_Processor,     // CPU 处理器
            Win32_PhysicalMemory,  // 物理内存条
            Win32_Keyboard,     // 键盘
            Win32_PointingDevice,  // 点输入设备，包括鼠标。
            Win32_FloppyDrive,    // 软盘驱动器
            Win32_DiskDrive,     // 硬盘驱动器
            Win32_CDROMDrive,    // 光盘驱动器
            Win32_BaseBoard,     // 主板
            Win32_BIOS,       // BIOS 芯片
            Win32_ParallelPort,   // 并口
            Win32_SerialPort,    // 串口
            Win32_SerialPortConfiguration, // 串口配置
            Win32_SoundDevice,    // 多媒体设置，一般指声卡。
            Win32_SystemSlot,    // 主板插槽 (ISA & PCI & AGP)
            Win32_USBController,   // USB 控制器
            Win32_NetworkAdapter,  // 网络适配器
            Win32_NetworkAdapterConfiguration, // 网络适配器设置
            Win32_Printer,      // 打印机
            Win32_PrinterConfiguration, // 打印机设置
            Win32_PrintJob,     // 打印机任务
            Win32_TCPIPPrinterPort, // 打印机端口
            Win32_POTSModem,     // MODEM
            Win32_POTSModemToSerialPort, // MODEM 端口
            Win32_DesktopMonitor,  // 显示器
            Win32_DisplayConfiguration, // 显卡
            Win32_DisplayControllerConfiguration, // 显卡设置
            Win32_VideoController, // 显卡细节。
            Win32_VideoSettings,  // 显卡支持的显示模式。
                                  // 操作系统
            Win32_TimeZone,     // 时区
            Win32_SystemDriver,   // 驱动程序
            Win32_DiskPartition,  // 磁盘分区
            Win32_LogicalDisk,   // 逻辑磁盘
            Win32_LogicalDiskToPartition,   // 逻辑磁盘所在分区及始末位置。
            Win32_LogicalMemoryConfiguration, // 逻辑内存配置
            Win32_PageFile,     // 系统页文件信息
            Win32_PageFileSetting, // 页文件设置
            Win32_BootConfiguration, // 系统启动配置
            Win32_ComputerSystem,  // 计算机信息简要
            Win32_OperatingSystem, // 操作系统信息
            Win32_StartupCommand,  // 系统自动启动程序
            Win32_Service,     // 系统安装的服务
            Win32_Group,      // 系统管理组
            Win32_GroupUser,    // 系统组帐号
            Win32_UserAccount,   // 用户帐号
            Win32_Process,     // 系统进程
            Win32_Thread,      // 系统线程
            Win32_Share,      // 共享
            Win32_NetworkClient,  // 已安装的网络客户端
            Win32_NetworkProtocol, // 已安装的网络协议
        }
        private Thread cpuThread;
        private Thread timeThread;
        private Thread listenThread;

        public Main()
        {
            
            InitializeComponent();

            GetOsInfo();
            GetCpuInfo();
            GetRamInfo();
            SystemInfo();

            label5.Text = "服务器IP："+hostip;
            label8.Text = "UDP: " + hostport;
            label7.Text = "TCP: " + (hostport-1);

            userTable.Columns.Add("id", typeof(string));
            userTable.Columns.Add("ip", typeof(string));
            userTable.Columns.Add("port",typeof(string));

            cpuThread = new Thread(new ThreadStart(this.getPerformanceCounters));
            cpuThread.IsBackground = true;
            timeThread = new Thread(new ThreadStart(this.UpdateTime));
            timeThread.IsBackground = true;
            listenThread = new Thread(new ThreadStart(this.ListenServer));
            listenThread.IsBackground = true;
            //获取外网IP
            WebClient webClient1 = new WebClient();
            webClient1.Credentials = CredentialCache.DefaultCredentials;
            byte[] pageDate = webClient1.DownloadData("http://pv.sohu.com/cityjson?ie=utf-8");
            String ip = Encoding.UTF8.GetString(pageDate);
            webClient1.Dispose();
            Match rebool = Regex.Match(ip, @"\d{2,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}");
            label5.Text = "互联网IP："+rebool.Value;
            
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            if (state == 1) {
                listenThread.Start();
                cpuThread.Start();
                timeThread.Start();
                state = 2; skinButton1.Text = "停止服务"; skinButton1.BaseColor = Color.FromArgb(247, 76, 49); skinButton1.MouseBaseColor = Color.LightCoral; skinButton1.DownBaseColor = Color.Salmon; }
            else {
                listenThread.Abort();
                cpuThread.Abort();
                timeThread.Abort();
                state = 1; skinButton1.Text = "启动服务"; skinButton1.BaseColor = Color.DodgerBlue; skinButton1.MouseBaseColor = Color.SkyBlue; skinButton1.DownBaseColor = Color.LightSkyBlue; }
       
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void getPerformanceCounters()
        {
            var cpuPerfCounter = new PerformanceCounter("Processor Information", "% Processor Time", "_Total");
            var ramPerfCounter = new PerformanceCounter("Memory", "% Committed Bytes In Use");
            var ioPerfCounter = new PerformanceCounter("PhysicalDisk", "% Disk Time", "_Total");
            while (true)
            {
                cpuArray[cpuArray.Length - 1] = Math.Round(cpuPerfCounter.NextValue(), 0);
                Array.Copy(cpuArray, 1, cpuArray, 0, cpuArray.Length - 1);
                ramArray[ramArray.Length - 1] = Math.Round(ramPerfCounter.NextValue(), 0);
                Array.Copy(ramArray, 1, ramArray, 0, ramArray.Length - 1);
                ioArray[ioArray.Length - 1] = Math.Round(ioPerfCounter.NextValue(), 0);
                Array.Copy(ioArray, 1, ioArray, 0, ioArray.Length - 1);
                if (cpuChart.IsHandleCreated)
                {
                    this.Invoke((MethodInvoker)delegate { UpdateCpuChart(); });
                }
                Thread.Sleep(500);

            }

        }
        private void UpdateTime()
        {
            while (true)
            {
                qt++;
                run++;
                this.Invoke((MethodInvoker)delegate {
                if (DebugBox.Lines.Length >= 2000)
                    {
                        DebugBox.Clear();
                    }
                UpdateTimeText(); });
                Thread.Sleep(1000);

            }
        }

        private void UpdateTimeText()
        {
            label1.Text = "启停：" + qt.ToString();
            label4.Text = "运行：" + run.ToString();
            zx = userTable.Rows.Count;
            label9.Text = "当前在线：" + zx.ToString();
            if (zx > zg)
            {
                zg = zx;
                label6.Text = "最高在线：" + zg.ToString();
            }
        }
        private void UpdateCpuChart()
        {
            cpuChart.Series["CPU使用率"].Points.Clear();
            cpuChart.Series["RAM使用率"].Points.Clear();
            cpuChart.Series["I / O 使用率"].Points.Clear();

            for (int i = 0; i < cpuArray.Length - 1; ++i)
            {
                cpuChart.Series["CPU使用率"].Points.AddY(cpuArray[i]);
                cpuChart.Series["RAM使用率"].Points.AddY(ramArray[i]);
                cpuChart.Series["I / O 使用率"].Points.AddY(ioArray[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cpuThread = new Thread(new ThreadStart(this.getPerformanceCounters));
            cpuThread.IsBackground = true;
            cpuThread.Start();
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            if (state == 1)
            {
                listenThread.Abort();
                cpuThread.Abort();
                timeThread.Abort();
                Application.Exit();
            }
            else
            {
                this.WindowState = FormWindowState.Minimized;
            }

        }

        private void SystemInfo()
        {
            SysInfoTextBox.AppendText("计算机名：" + Environment.MachineName);
            SysInfoTextBox.AppendText(Environment.NewLine);
            string[] osArray = os.Split('|');
            SysInfoTextBox.AppendText("操作系统：" + osArray[0]);
            SysInfoTextBox.AppendText(Environment.NewLine);
            //判断操作系统位数  
            if (Environment.Is64BitOperatingSystem)
            {
                
                SysInfoTextBox.AppendText("位数：64位");
            }
            else
            {
                SysInfoTextBox.AppendText("位数：32位");
            }
            SysInfoTextBox.AppendText(Environment.NewLine);
            SysInfoTextBox.AppendText("处理器型号：" + cpu);
            SysInfoTextBox.AppendText(Environment.NewLine);
            SysInfoTextBox.AppendText("核心数量：" + Environment.ProcessorCount+"核");
            SysInfoTextBox.AppendText(Environment.NewLine);
            SysInfoTextBox.AppendText("安装内存：" + ram + " MB");



        }
        public void GetOsInfo()
        {
            try
            {
                ManagementClass mc = new ManagementClass(WMIPath.Win32_OperatingSystem.ToString());
                ManagementObjectCollection moc = mc.GetInstances();
                foreach (ManagementObject mo in moc)
                {
                    os = ("" + mo.Properties["Name"].Value);


                }
            }
            catch
            {
                Console.WriteLine("未知版本");
            }
        }

        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            downPoint = new Point(e.X, e.Y);
        }

        private void Main_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - downPoint.X,
                    this.Location.Y + e.Y - downPoint.Y);
            }
        }

        private void Main_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            downPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - downPoint.X,
                    this.Location.Y + e.Y - downPoint.Y);
            }
        }

        private void skinButton3_Click(object sender, EventArgs e)
        {
            DebugBox.Clear();
        }

        private void DebugBox_TextChanged(object sender, EventArgs e)
        {
            DebugBox.ScrollToCaret();
        }

        public void GetCpuInfo()
        {
            try
            {
                ManagementClass mc = new ManagementClass(WMIPath.Win32_Processor.ToString());
                ManagementObjectCollection moc = mc.GetInstances();
                foreach (ManagementObject mo in moc)
                {
                    cpu=("" + mo.Properties["Name"].Value);
                }
            }
            catch
            {
                cpu=("未知型号");
            }
        }
        public void GetRamInfo()
        {
            try
            {
                ManagementClass mc = new ManagementClass(WMIPath.Win32_PhysicalMemory.ToString());
                ManagementObjectCollection moc = mc.GetInstances();
                foreach (ManagementObject mo in moc)
                {
                    ram += Convert.ToInt32((Math.Round(Int64.Parse(mo.Properties["Capacity"].Value.ToString()) / 1024 / 1024.0, 1)));
                }
              
                
            }
            catch
            {
                Console.WriteLine("未知大小");
            }
        }

        public void ListenServer()
        {
            //监听端口
            IPEndPoint udpPoint = new IPEndPoint(IPAddress.Any, hostport);
            UdpClient udpClient = new UdpClient(udpPoint);
            IPEndPoint senderPoint = new IPEndPoint(IPAddress.Any, 0);
            GifRichTextBox transrtf = new LinkerServer.GifRichTextBox();
            try
            {
                while (true)
                {
                    byte[] bytes = udpClient.Receive(ref senderPoint);
                    string strIP = "来自：" + senderPoint.Address.ToString() + ":" + senderPoint.Port.ToString();
                    string strInfo = Encoding.GetEncoding("gb2312").GetString(bytes, 0, bytes.Length);
                    transrtf.Rtf = strInfo;strInfo = transrtf.Text.ToString();
                    
                    //请求外网地址：指令格式：GET:
                    if (strInfo.Contains("NAT"))
                    {
                        //返回外网地址
                        string sendMsg = "" + senderPoint.Address.ToString() + ":" + senderPoint.Port.ToString();
                        transrtf.Text = sendMsg;
                        sendMsg = transrtf.Rtf;
                        byte[] sendData = Encoding.Default.GetBytes(sendMsg);
                        
                        udpClient.Send(sendData, sendData.Length, senderPoint);

                        //更新日志
                        this.Invoke((MethodInvoker)delegate
                        {
                            DebugBox.AppendText(strIP + " 内容：请求NAT地址");
                            DebugBox.AppendText(Environment.NewLine);
                        });


                    }
                    //用户连接：指令格式：LOGIN:10001
                    else if (strInfo.Contains("LOGN:"))
                    {
                        //返回外网地址
                        string[] sArray = Regex.Split(strInfo, ":", RegexOptions.IgnoreCase);
                        string sendMsg = "NAT" + senderPoint.Address.ToString() + ":" + senderPoint.Port.ToString();
                        transrtf.Text = sendMsg;
                        sendMsg = transrtf.Rtf;
                        byte[] sendData = Encoding.Default.GetBytes(sendMsg);
                        udpClient.Send(sendData, sendData.Length, senderPoint);

                        //添加用户到数据表
                        //如果已添加过就删除后再添加
                        if (userTable.Select("id='" + sArray[1] + "'").Length > 0)
                        {
                            foreach (DataRow row in userTable.Select("id='" + sArray[1] + "'"))
                            {
                                userTable.Rows.Remove(row);
                            }
                        }
                        userTable.Rows.Add(sArray[1], senderPoint.Address.ToString(), senderPoint.Port.ToString());

                        //更新日志
                        this.Invoke((MethodInvoker)delegate
                        {
                            DebugBox.AppendText(strIP + " 内容：" + sArray[1] + "已连接");
                            DebugBox.AppendText(Environment.NewLine);
                        });
                    }

                    //用户连接其他用户：指令格式：LINK:10001:10002
                    else if (strInfo.Contains("LINK:"))
                    {
                        //查询 请求用户A 与 目标用户B 的NAT地址
                        //MessageBox.Show(userTable.Select("id='" + sArray[2] + "'")[0]["id"].ToString());

                        string[] sArray = Regex.Split(strInfo, ":", RegexOptions.IgnoreCase);
                        DataRow[] dtA = userTable.Select("id='" + sArray[1] + "'");
                        IPEndPoint targetPointA = new IPEndPoint(IPAddress.Parse(dtA[0]["ip"].ToString()), Convert.ToInt32(dtA[0]["port"]));
                        IPEndPoint targetPointB = senderPoint;

                        //给 目标用户B 发送 请求用户A 的NAT地址
                        string sendMsg = "@L@I@N@K:" + targetPointA.Address.ToString() + ":" + targetPointA.Port.ToString();
                        transrtf.Text = sendMsg;
                        sendMsg = transrtf.Rtf;
                        byte[] sendData = Encoding.Default.GetBytes(sendMsg);
                        udpClient.Send(sendData, sendData.Length, targetPointB);

                        //给 请求用户A 返回 目标用户B 的NAT地址
                        string sendMsg2 = "@L@I@N@K:" + targetPointB.Address.ToString() + ":" + targetPointB.Port.ToString();
                        transrtf.Text = sendMsg2;
                        sendMsg2 = transrtf.Rtf;
                        byte[] sendData2 = Encoding.Default.GetBytes(sendMsg2);
                        udpClient.Send(sendData2, sendData2.Length, targetPointA);

                        this.Invoke((MethodInvoker)delegate
                        {
                            DebugBox.AppendText(strIP + " 内容：" + sArray[1] + "与其他用户" + "已连接");
                            DebugBox.AppendText(Environment.NewLine);
                        });
                    }

                    else if (strInfo.Contains("LOUT:"))
                    {
                        //用户离线删除登记信息
                        string[] sArray = Regex.Split(strInfo, ":", RegexOptions.IgnoreCase);
                        foreach (DataRow row in userTable.Select("id='" + sArray[1] + "'"))
                        {
                            userTable.Rows.Remove(row);
                        }
                        //更新日志
                        this.Invoke((MethodInvoker)delegate
                        {
                            DebugBox.AppendText(strIP + " 内容：" + sArray[1] + "已断开");
                            DebugBox.AppendText(Environment.NewLine);
                        });
                    }


                    else if (strInfo.Contains("HOME"))
                    {
                        //欢迎与功能菜单
                        string sendMsg = "欢迎使用MSGServer" + "      在线[" + userTable.Rows.Count.ToString()+"]人";
                        transrtf.Text = sendMsg;
                        transrtf.AppendText(Environment.NewLine);
                        transrtf.AppendText("----------------------------------");
                        transrtf.AppendText(Environment.NewLine);
                        transrtf.AppendText("HOME 功能菜单        NAT  获取地址");
                        transrtf.AppendText(Environment.NewLine);
                        transrtf.AppendText("LIST 用户列表        TOTA 统计信息");
                        transrtf.AppendText(Environment.NewLine);
                        transrtf.AppendText("LINK:ID 连接用户     HELP 获取帮助");
                        transrtf.AppendText(Environment.NewLine);
                        transrtf.AppendText("CLEA 清除记录        PROE 设置参数");
                        sendMsg = transrtf.Rtf;
                        byte[] sendData = Encoding.Default.GetBytes(sendMsg);
                        udpClient.Send(sendData, sendData.Length, senderPoint);
                     
                    }
                    else if (strInfo.Contains("LIST"))
                    {
                        string sendMsg = "MSGServer当前用户列表" + "  在线[" + userTable.Rows.Count.ToString() + "]人";
                        transrtf.Text = sendMsg;
                        transrtf.AppendText(Environment.NewLine);
                        transrtf.AppendText("-----------------------------------");
                        transrtf.AppendText(Environment.NewLine);
                        for (int i=0; i < userTable.Rows.Count; i++)
                        {
                            string id = userTable.Rows[i][0].ToString();
                            string ip = userTable.Rows[i][1].ToString();
                            string port = userTable.Rows[i][2].ToString();
                            transrtf.AppendText("ID:" + id + "IP:" + ip+"PT:"+port);
                            transrtf.AppendText(Environment.NewLine);
                        }
                        sendMsg = transrtf.Rtf;
                        byte[] sendData = Encoding.Default.GetBytes(sendMsg);
                        udpClient.Send(sendData, sendData.Length, senderPoint);
                    }

                    else
                    {
                    }
                    Thread.Sleep(100);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }


        }

    }
}


