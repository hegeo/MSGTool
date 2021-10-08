namespace LinkerServer
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
            this.cpuChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CloseButton = new CCWin.SkinControl.SkinButton();
            this.SysInfoTextBox = new CCWin.SkinControl.SkinChatRichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.skinPanel2 = new CCWin.SkinControl.SkinPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.skinPanel3 = new CCWin.SkinControl.SkinPanel();
            this.skinButton5 = new CCWin.SkinControl.SkinButton();
            this.skinButton4 = new CCWin.SkinControl.SkinButton();
            this.skinButton3 = new CCWin.SkinControl.SkinButton();
            this.skinButton2 = new CCWin.SkinControl.SkinButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.DebugBox = new CCWin.SkinControl.SkinChatRichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.skinPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpuChart)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.skinPanel2.SuspendLayout();
            this.skinPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinButton1
            // 
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.BaseColor = System.Drawing.Color.DodgerBlue;
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.DownBack = null;
            this.skinButton1.DownBaseColor = System.Drawing.Color.SkyBlue;
            this.skinButton1.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.skinButton1.ForeColor = System.Drawing.Color.White;
            this.skinButton1.IsDrawBorder = false;
            this.skinButton1.IsDrawGlass = false;
            this.skinButton1.Location = new System.Drawing.Point(11, 17);
            this.skinButton1.MouseBack = null;
            this.skinButton1.MouseBaseColor = System.Drawing.Color.DeepSkyBlue;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.Radius = 4;
            this.skinButton1.Size = new System.Drawing.Size(73, 35);
            this.skinButton1.TabIndex = 0;
            this.skinButton1.Text = "开启服务";
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Click += new System.EventHandler(this.skinButton1_Click);
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.skinPanel1.Controls.Add(this.cpuChart);
            this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel1.DownBack = null;
            this.skinPanel1.Location = new System.Drawing.Point(280, 65);
            this.skinPanel1.MouseBack = null;
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.NormlBack = null;
            this.skinPanel1.Size = new System.Drawing.Size(502, 204);
            this.skinPanel1.TabIndex = 1;
            // 
            // cpuChart
            // 
            this.cpuChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.cpuChart.BorderSkin.BorderColor = System.Drawing.Color.Silver;
            chartArea3.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea3.AxisX.LabelStyle.ForeColor = System.Drawing.Color.Silver;
            chartArea3.AxisX.LineColor = System.Drawing.Color.Silver;
            chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea3.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea3.AxisX.MinorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea3.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.Silver;
            chartArea3.AxisX.TitleForeColor = System.Drawing.Color.Silver;
            chartArea3.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea3.AxisX2.LineColor = System.Drawing.Color.Silver;
            chartArea3.AxisX2.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea3.AxisX2.MajorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea3.AxisX2.MinorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea3.AxisX2.MinorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea3.AxisX2.ScaleBreakStyle.LineColor = System.Drawing.Color.Silver;
            chartArea3.AxisX2.TitleForeColor = System.Drawing.Color.Silver;
            chartArea3.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Silver;
            chartArea3.AxisY.LineColor = System.Drawing.Color.Silver;
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea3.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea3.AxisY.MinorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea3.AxisY.MinorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea3.AxisY.ScaleBreakStyle.LineColor = System.Drawing.Color.Silver;
            chartArea3.AxisY.TitleForeColor = System.Drawing.Color.Silver;
            chartArea3.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea3.AxisY2.LineColor = System.Drawing.Color.Silver;
            chartArea3.AxisY2.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea3.AxisY2.MajorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea3.AxisY2.MinorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea3.AxisY2.MinorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea3.AxisY2.ScaleBreakStyle.LineColor = System.Drawing.Color.Silver;
            chartArea3.AxisY2.TitleForeColor = System.Drawing.Color.Silver;
            chartArea3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            chartArea3.BorderColor = System.Drawing.Color.Silver;
            chartArea3.Name = "ChartArea1";
            this.cpuChart.ChartAreas.Add(chartArea3);
            this.cpuChart.Cursor = System.Windows.Forms.Cursors.Default;
            legend3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            legend3.ForeColor = System.Drawing.Color.Silver;
            legend3.Name = "Legend1";
            this.cpuChart.Legends.Add(legend3);
            this.cpuChart.Location = new System.Drawing.Point(0, 0);
            this.cpuChart.Name = "cpuChart";
            series7.ChartArea = "ChartArea1";
            series7.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            series7.Legend = "Legend1";
            series7.Name = "CPU使用率";
            series7.YValuesPerPoint = 4;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series8.Legend = "Legend1";
            series8.Name = "RAM使用率";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series9.Legend = "Legend1";
            series9.Name = "I / O 使用率";
            series9.YValuesPerPoint = 2;
            this.cpuChart.Series.Add(series7);
            this.cpuChart.Series.Add(series8);
            this.cpuChart.Series.Add(series9);
            this.cpuChart.Size = new System.Drawing.Size(502, 204);
            this.cpuChart.TabIndex = 0;
            this.cpuChart.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Controls.Add(this.SysInfoTextBox);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 562);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.CloseButton.DownBack = ((System.Drawing.Image)(resources.GetObject("CloseButton.DownBack")));
            this.CloseButton.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.CloseButton.IsDrawBorder = false;
            this.CloseButton.Location = new System.Drawing.Point(5, 4);
            this.CloseButton.MouseBack = ((System.Drawing.Image)(resources.GetObject("CloseButton.MouseBack")));
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.NormlBack = ((System.Drawing.Image)(resources.GetObject("CloseButton.NormlBack")));
            this.CloseButton.Size = new System.Drawing.Size(16, 16);
            this.CloseButton.TabIndex = 16;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // SysInfoTextBox
            // 
            this.SysInfoTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.SysInfoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SysInfoTextBox.ContextMenuMode = CCWin.SkinControl.ChatBoxContextMenuMode.None;
            this.SysInfoTextBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SysInfoTextBox.ForeColor = System.Drawing.Color.Silver;
            this.SysInfoTextBox.Location = new System.Drawing.Point(16, 118);
            this.SysInfoTextBox.Name = "SysInfoTextBox";
            this.SysInfoTextBox.PopoutImageWhenDoubleClick = false;
            this.SysInfoTextBox.ReadOnly = true;
            this.SysInfoTextBox.SelectControl = null;
            this.SysInfoTextBox.SelectControlIndex = 0;
            this.SysInfoTextBox.SelectControlPoint = new System.Drawing.Point(0, 0);
            this.SysInfoTextBox.Size = new System.Drawing.Size(248, 345);
            this.SysInfoTextBox.TabIndex = 15;
            this.SysInfoTextBox.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label11.ForeColor = System.Drawing.Color.Silver;
            this.label11.Location = new System.Drawing.Point(13, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 17);
            this.label11.TabIndex = 13;
            this.label11.Text = "服务器信息";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(103, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "V2.0.1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.Color.Silver;
            this.label10.Location = new System.Drawing.Point(102, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 19);
            this.label10.TabIndex = 5;
            this.label10.Text = "service management";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(102, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "MSG服务管理器";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(46, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(99, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "启停：0";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // skinPanel2
            // 
            this.skinPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.skinPanel2.Controls.Add(this.panel4);
            this.skinPanel2.Controls.Add(this.panel3);
            this.skinPanel2.Controls.Add(this.panel2);
            this.skinPanel2.Controls.Add(this.label9);
            this.skinPanel2.Controls.Add(this.label6);
            this.skinPanel2.Controls.Add(this.label8);
            this.skinPanel2.Controls.Add(this.label7);
            this.skinPanel2.Controls.Add(this.label5);
            this.skinPanel2.Controls.Add(this.label4);
            this.skinPanel2.Controls.Add(this.skinButton1);
            this.skinPanel2.Controls.Add(this.label1);
            this.skinPanel2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel2.DownBack = null;
            this.skinPanel2.Location = new System.Drawing.Point(280, -2);
            this.skinPanel2.MouseBack = null;
            this.skinPanel2.Name = "skinPanel2";
            this.skinPanel2.NormlBack = null;
            this.skinPanel2.Size = new System.Drawing.Size(502, 66);
            this.skinPanel2.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel4.Location = new System.Drawing.Point(94, 17);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(2, 35);
            this.panel4.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel3.Location = new System.Drawing.Point(384, 17);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2, 35);
            this.panel3.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lime;
            this.panel2.Location = new System.Drawing.Point(217, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 35);
            this.panel2.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label9.ForeColor = System.Drawing.Color.Silver;
            this.label9.Location = new System.Drawing.Point(388, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "当前在线：0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(388, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "最高在线：0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(304, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "UDP：4200";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(222, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "TCP：4000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(223, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "服务器IP：127.0.0.1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(99, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "运行：0";
            // 
            // skinPanel3
            // 
            this.skinPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.skinPanel3.Controls.Add(this.skinButton5);
            this.skinPanel3.Controls.Add(this.skinButton4);
            this.skinPanel3.Controls.Add(this.skinButton3);
            this.skinPanel3.Controls.Add(this.skinButton2);
            this.skinPanel3.Controls.Add(this.textBox1);
            this.skinPanel3.Controls.Add(this.label12);
            this.skinPanel3.Controls.Add(this.DebugBox);
            this.skinPanel3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel3.DownBack = null;
            this.skinPanel3.Location = new System.Drawing.Point(280, 270);
            this.skinPanel3.MouseBack = null;
            this.skinPanel3.Name = "skinPanel3";
            this.skinPanel3.NormlBack = null;
            this.skinPanel3.Size = new System.Drawing.Size(502, 290);
            this.skinPanel3.TabIndex = 2;
            // 
            // skinButton5
            // 
            this.skinButton5.BackColor = System.Drawing.Color.Transparent;
            this.skinButton5.BaseColor = System.Drawing.Color.DodgerBlue;
            this.skinButton5.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton5.DownBack = null;
            this.skinButton5.DownBaseColor = System.Drawing.Color.SkyBlue;
            this.skinButton5.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.skinButton5.ForeColor = System.Drawing.Color.White;
            this.skinButton5.IsDrawBorder = false;
            this.skinButton5.IsDrawGlass = false;
            this.skinButton5.Location = new System.Drawing.Point(233, 258);
            this.skinButton5.MouseBack = null;
            this.skinButton5.MouseBaseColor = System.Drawing.Color.DeepSkyBlue;
            this.skinButton5.Name = "skinButton5";
            this.skinButton5.NormlBack = null;
            this.skinButton5.Radius = 4;
            this.skinButton5.Size = new System.Drawing.Size(60, 21);
            this.skinButton5.TabIndex = 23;
            this.skinButton5.Text = "运行指令";
            this.skinButton5.UseVisualStyleBackColor = false;
            // 
            // skinButton4
            // 
            this.skinButton4.BackColor = System.Drawing.Color.Transparent;
            this.skinButton4.BaseColor = System.Drawing.Color.DodgerBlue;
            this.skinButton4.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton4.DownBack = null;
            this.skinButton4.DownBaseColor = System.Drawing.Color.SkyBlue;
            this.skinButton4.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.skinButton4.ForeColor = System.Drawing.Color.White;
            this.skinButton4.IsDrawBorder = false;
            this.skinButton4.IsDrawGlass = false;
            this.skinButton4.Location = new System.Drawing.Point(297, 258);
            this.skinButton4.MouseBack = null;
            this.skinButton4.MouseBaseColor = System.Drawing.Color.DeepSkyBlue;
            this.skinButton4.Name = "skinButton4";
            this.skinButton4.NormlBack = null;
            this.skinButton4.Radius = 4;
            this.skinButton4.Size = new System.Drawing.Size(60, 21);
            this.skinButton4.TabIndex = 22;
            this.skinButton4.Text = "用户列表";
            this.skinButton4.UseVisualStyleBackColor = false;
            // 
            // skinButton3
            // 
            this.skinButton3.BackColor = System.Drawing.Color.Transparent;
            this.skinButton3.BaseColor = System.Drawing.Color.DodgerBlue;
            this.skinButton3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton3.DownBack = null;
            this.skinButton3.DownBaseColor = System.Drawing.Color.SkyBlue;
            this.skinButton3.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.skinButton3.ForeColor = System.Drawing.Color.White;
            this.skinButton3.IsDrawBorder = false;
            this.skinButton3.IsDrawGlass = false;
            this.skinButton3.Location = new System.Drawing.Point(425, 258);
            this.skinButton3.MouseBack = null;
            this.skinButton3.MouseBaseColor = System.Drawing.Color.DeepSkyBlue;
            this.skinButton3.Name = "skinButton3";
            this.skinButton3.NormlBack = null;
            this.skinButton3.Radius = 4;
            this.skinButton3.Size = new System.Drawing.Size(60, 21);
            this.skinButton3.TabIndex = 21;
            this.skinButton3.Text = "清理日志";
            this.skinButton3.UseVisualStyleBackColor = false;
            this.skinButton3.Click += new System.EventHandler(this.skinButton3_Click);
            // 
            // skinButton2
            // 
            this.skinButton2.BackColor = System.Drawing.Color.Transparent;
            this.skinButton2.BaseColor = System.Drawing.Color.DodgerBlue;
            this.skinButton2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton2.DownBack = null;
            this.skinButton2.DownBaseColor = System.Drawing.Color.SkyBlue;
            this.skinButton2.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.skinButton2.ForeColor = System.Drawing.Color.White;
            this.skinButton2.IsDrawBorder = false;
            this.skinButton2.IsDrawGlass = false;
            this.skinButton2.Location = new System.Drawing.Point(361, 258);
            this.skinButton2.MouseBack = null;
            this.skinButton2.MouseBaseColor = System.Drawing.Color.DeepSkyBlue;
            this.skinButton2.Name = "skinButton2";
            this.skinButton2.NormlBack = null;
            this.skinButton2.Radius = 4;
            this.skinButton2.Size = new System.Drawing.Size(60, 21);
            this.skinButton2.TabIndex = 13;
            this.skinButton2.Text = "服务菜单";
            this.skinButton2.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(59)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.ForeColor = System.Drawing.Color.LightGray;
            this.textBox1.Location = new System.Drawing.Point(20, 258);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 23);
            this.textBox1.TabIndex = 20;
            this.textBox1.Text = "请输入指令";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label12.ForeColor = System.Drawing.Color.Silver;
            this.label12.Location = new System.Drawing.Point(18, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 17);
            this.label12.TabIndex = 17;
            this.label12.Text = "连接日志";
            // 
            // DebugBox
            // 
            this.DebugBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.DebugBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DebugBox.ContextMenuMode = CCWin.SkinControl.ChatBoxContextMenuMode.None;
            this.DebugBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DebugBox.ForeColor = System.Drawing.Color.Silver;
            this.DebugBox.Location = new System.Drawing.Point(21, 32);
            this.DebugBox.Name = "DebugBox";
            this.DebugBox.PopoutImageWhenDoubleClick = false;
            this.DebugBox.ReadOnly = true;
            this.DebugBox.SelectControl = null;
            this.DebugBox.SelectControlIndex = 0;
            this.DebugBox.SelectControlPoint = new System.Drawing.Point(0, 0);
            this.DebugBox.Size = new System.Drawing.Size(463, 207);
            this.DebugBox.TabIndex = 16;
            this.DebugBox.Text = "";
            this.DebugBox.TextChanged += new System.EventHandler(this.DebugBox_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label13.ForeColor = System.Drawing.Color.Silver;
            this.label13.Location = new System.Drawing.Point(20, 454);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(248, 85);
            this.label13.TabIndex = 17;
            this.label13.Text = "[这是什么]\r\n一个内网穿透通讯服务框架，你可以用它实现\r\n服务器监管，远程控制，网络通讯等多种功能\r\n[客户端下载]\r\nhttps://github.com/e" +
    "ncvstin";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.skinPanel3);
            this.Controls.Add(this.skinPanel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.skinPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            this.skinPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cpuChart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.skinPanel2.ResumeLayout(false);
            this.skinPanel2.PerformLayout();
            this.skinPanel3.ResumeLayout(false);
            this.skinPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinButton skinButton1;
        private CCWin.SkinControl.SkinPanel skinPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private CCWin.SkinControl.SkinPanel skinPanel2;
        private CCWin.SkinControl.SkinPanel skinPanel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataVisualization.Charting.Chart cpuChart;
        private System.Windows.Forms.Label label11;
        private CCWin.SkinControl.SkinChatRichTextBox SysInfoTextBox;
        private CCWin.SkinControl.SkinButton CloseButton;
        private CCWin.SkinControl.SkinChatRichTextBox DebugBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox1;
        private CCWin.SkinControl.SkinButton skinButton2;
        private CCWin.SkinControl.SkinButton skinButton3;
        private CCWin.SkinControl.SkinButton skinButton5;
        private CCWin.SkinControl.SkinButton skinButton4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
    }
}