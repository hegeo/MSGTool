namespace MSGTool
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.targetip = new System.Windows.Forms.TextBox();
            this.button_send = new CCWin.SkinControl.SkinButton();
            this.targetport = new System.Windows.Forms.TextBox();
            this.receiveport = new System.Windows.Forms.TextBox();
            this.receiveip = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.mainlabel1 = new System.Windows.Forms.Label();
            this.CloseButton = new CCWin.SkinControl.SkinButton();
            this.button_emoji = new CCWin.SkinControl.SkinButton();
            this.button_connect = new CCWin.SkinControl.SkinButton();
            this.logo = new System.Windows.Forms.PictureBox();
            this.mainabel2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_image = new CCWin.SkinControl.SkinButton();
            this.idlabel = new System.Windows.Forms.Label();
            this.helplabel = new System.Windows.Forms.Label();
            this.button_history = new CCWin.SkinControl.SkinButton();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.idtext = new System.Windows.Forms.Label();
            this.button_server = new CCWin.SkinControl.SkinButton();
            this.receivemsg = new MSGTool.GifRichTextBox();
            this.inputmsg = new MSGTool.GifRichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // targetip
            // 
            this.targetip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(59)))));
            this.targetip.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.targetip.ForeColor = System.Drawing.Color.LightGray;
            this.targetip.Location = new System.Drawing.Point(12, 81);
            this.targetip.Name = "targetip";
            this.targetip.Size = new System.Drawing.Size(170, 14);
            this.targetip.TabIndex = 0;
            this.targetip.Text = "目标IP";
            // 
            // button_send
            // 
            this.button_send.BackColor = System.Drawing.Color.Transparent;
            this.button_send.BaseColor = System.Drawing.Color.DodgerBlue;
            this.button_send.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.button_send.DownBack = null;
            this.button_send.DownBaseColor = System.Drawing.Color.SkyBlue;
            this.button_send.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.button_send.ForeColor = System.Drawing.Color.White;
            this.button_send.IsDrawBorder = false;
            this.button_send.IsDrawGlass = false;
            this.button_send.Location = new System.Drawing.Point(10, 194);
            this.button_send.MouseBack = null;
            this.button_send.MouseBaseColor = System.Drawing.Color.DeepSkyBlue;
            this.button_send.Name = "button_send";
            this.button_send.NormlBack = null;
            this.button_send.Radius = 4;
            this.button_send.Size = new System.Drawing.Size(38, 21);
            this.button_send.TabIndex = 24;
            this.button_send.Text = "发送";
            this.button_send.UseVisualStyleBackColor = false;
            this.button_send.Click += new System.EventHandler(this.skinButton5_Click);
            // 
            // targetport
            // 
            this.targetport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(59)))));
            this.targetport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.targetport.ForeColor = System.Drawing.Color.LightGray;
            this.targetport.Location = new System.Drawing.Point(188, 81);
            this.targetport.Name = "targetport";
            this.targetport.Size = new System.Drawing.Size(54, 14);
            this.targetport.TabIndex = 25;
            this.targetport.Text = "端口";
            this.targetport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // receiveport
            // 
            this.receiveport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(59)))));
            this.receiveport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.receiveport.ForeColor = System.Drawing.Color.LightGray;
            this.receiveport.Location = new System.Drawing.Point(188, 237);
            this.receiveport.Name = "receiveport";
            this.receiveport.Size = new System.Drawing.Size(54, 14);
            this.receiveport.TabIndex = 29;
            this.receiveport.Text = "端口";
            this.receiveport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // receiveip
            // 
            this.receiveip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(59)))));
            this.receiveip.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.receiveip.ForeColor = System.Drawing.Color.LightGray;
            this.receiveip.Location = new System.Drawing.Point(12, 237);
            this.receiveip.Name = "receiveip";
            this.receiveip.Size = new System.Drawing.Size(170, 14);
            this.receiveip.TabIndex = 27;
            this.receiveip.Text = "来自IP";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(59)))));
            this.panel4.Location = new System.Drawing.Point(1, 225);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(253, 1);
            this.panel4.TabIndex = 30;
            // 
            // mainlabel1
            // 
            this.mainlabel1.AutoSize = true;
            this.mainlabel1.ForeColor = System.Drawing.Color.LightGray;
            this.mainlabel1.Location = new System.Drawing.Point(107, 23);
            this.mainlabel1.Name = "mainlabel1";
            this.mainlabel1.Size = new System.Drawing.Size(77, 12);
            this.mainlabel1.TabIndex = 31;
            this.mainlabel1.Text = "通讯测试工具";
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.CloseButton.DownBack = ((System.Drawing.Image)(resources.GetObject("CloseButton.DownBack")));
            this.CloseButton.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.CloseButton.IsDrawBorder = false;
            this.CloseButton.Location = new System.Drawing.Point(4, 4);
            this.CloseButton.MouseBack = ((System.Drawing.Image)(resources.GetObject("CloseButton.MouseBack")));
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.NormlBack = ((System.Drawing.Image)(resources.GetObject("CloseButton.NormlBack")));
            this.CloseButton.Size = new System.Drawing.Size(16, 16);
            this.CloseButton.TabIndex = 33;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // button_emoji
            // 
            this.button_emoji.BackColor = System.Drawing.Color.Transparent;
            this.button_emoji.BaseColor = System.Drawing.Color.DodgerBlue;
            this.button_emoji.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.button_emoji.DownBack = null;
            this.button_emoji.DownBaseColor = System.Drawing.Color.SkyBlue;
            this.button_emoji.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.button_emoji.ForeColor = System.Drawing.Color.White;
            this.button_emoji.IsDrawBorder = false;
            this.button_emoji.IsDrawGlass = false;
            this.button_emoji.Location = new System.Drawing.Point(48, 194);
            this.button_emoji.MouseBack = null;
            this.button_emoji.MouseBaseColor = System.Drawing.Color.DeepSkyBlue;
            this.button_emoji.Name = "button_emoji";
            this.button_emoji.NormlBack = null;
            this.button_emoji.Radius = 4;
            this.button_emoji.Size = new System.Drawing.Size(38, 21);
            this.button_emoji.TabIndex = 34;
            this.button_emoji.Text = "会话";
            this.button_emoji.UseVisualStyleBackColor = false;
            this.button_emoji.Click += new System.EventHandler(this.skinButton1_Click);
            // 
            // button_connect
            // 
            this.button_connect.BackColor = System.Drawing.Color.Transparent;
            this.button_connect.BaseColor = System.Drawing.Color.DodgerBlue;
            this.button_connect.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.button_connect.DownBack = null;
            this.button_connect.DownBaseColor = System.Drawing.Color.SkyBlue;
            this.button_connect.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.button_connect.ForeColor = System.Drawing.Color.White;
            this.button_connect.IsDrawBorder = false;
            this.button_connect.IsDrawGlass = false;
            this.button_connect.Location = new System.Drawing.Point(206, 194);
            this.button_connect.MouseBack = null;
            this.button_connect.MouseBaseColor = System.Drawing.Color.DeepSkyBlue;
            this.button_connect.Name = "button_connect";
            this.button_connect.NormlBack = null;
            this.button_connect.Radius = 4;
            this.button_connect.Size = new System.Drawing.Size(38, 21);
            this.button_connect.TabIndex = 35;
            this.button_connect.Text = "启动";
            this.button_connect.UseVisualStyleBackColor = false;
            this.button_connect.Click += new System.EventHandler(this.skinButton2_Click);
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(71, 21);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(30, 30);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 36;
            this.logo.TabStop = false;
            // 
            // mainabel2
            // 
            this.mainabel2.AutoSize = true;
            this.mainabel2.ForeColor = System.Drawing.Color.LightGray;
            this.mainabel2.Location = new System.Drawing.Point(109, 37);
            this.mainabel2.Name = "mainabel2";
            this.mainabel2.Size = new System.Drawing.Size(47, 12);
            this.mainabel2.TabIndex = 37;
            this.mainabel2.Text = "MSGtool";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(59)))));
            this.panel1.Location = new System.Drawing.Point(4, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 1);
            this.panel1.TabIndex = 31;
            // 
            // button_image
            // 
            this.button_image.BackColor = System.Drawing.Color.Transparent;
            this.button_image.BaseColor = System.Drawing.Color.DodgerBlue;
            this.button_image.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.button_image.DownBack = null;
            this.button_image.DownBaseColor = System.Drawing.Color.SkyBlue;
            this.button_image.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.button_image.ForeColor = System.Drawing.Color.White;
            this.button_image.IsDrawBorder = false;
            this.button_image.IsDrawGlass = false;
            this.button_image.Location = new System.Drawing.Point(86, 194);
            this.button_image.MouseBack = null;
            this.button_image.MouseBaseColor = System.Drawing.Color.DeepSkyBlue;
            this.button_image.Name = "button_image";
            this.button_image.NormlBack = null;
            this.button_image.Radius = 4;
            this.button_image.Size = new System.Drawing.Size(38, 21);
            this.button_image.TabIndex = 38;
            this.button_image.Text = "表情";
            this.button_image.UseVisualStyleBackColor = false;
            this.button_image.Click += new System.EventHandler(this.skinButton3_Click);
            // 
            // idlabel
            // 
            this.idlabel.AutoSize = true;
            this.idlabel.ForeColor = System.Drawing.Color.DimGray;
            this.idlabel.Location = new System.Drawing.Point(28, 358);
            this.idlabel.Name = "idlabel";
            this.idlabel.Size = new System.Drawing.Size(29, 12);
            this.idlabel.TabIndex = 39;
            this.idlabel.Text = "5281";
            // 
            // helplabel
            // 
            this.helplabel.AutoSize = true;
            this.helplabel.ForeColor = System.Drawing.Color.DimGray;
            this.helplabel.Location = new System.Drawing.Point(190, 358);
            this.helplabel.Name = "helplabel";
            this.helplabel.Size = new System.Drawing.Size(53, 12);
            this.helplabel.TabIndex = 41;
            this.helplabel.Text = "帮助信息";
            this.helplabel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.label5_MouseClick);
            // 
            // button_history
            // 
            this.button_history.BackColor = System.Drawing.Color.Transparent;
            this.button_history.BaseColor = System.Drawing.Color.DodgerBlue;
            this.button_history.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.button_history.DownBack = null;
            this.button_history.DownBaseColor = System.Drawing.Color.SkyBlue;
            this.button_history.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.button_history.ForeColor = System.Drawing.Color.White;
            this.button_history.IsDrawBorder = false;
            this.button_history.IsDrawGlass = false;
            this.button_history.Location = new System.Drawing.Point(124, 194);
            this.button_history.MouseBack = null;
            this.button_history.MouseBaseColor = System.Drawing.Color.DeepSkyBlue;
            this.button_history.Name = "button_history";
            this.button_history.NormlBack = null;
            this.button_history.Radius = 4;
            this.button_history.Size = new System.Drawing.Size(38, 21);
            this.button_history.TabIndex = 43;
            this.button_history.Text = "列表";
            this.button_history.UseVisualStyleBackColor = false;
            this.button_history.Click += new System.EventHandler(this.skinButton4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.LightGray;
            this.label6.Location = new System.Drawing.Point(274, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 12);
            this.label6.TabIndex = 45;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox1.ForeColor = System.Drawing.Color.LightGray;
            this.richTextBox1.Location = new System.Drawing.Point(263, 54);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(245, 323);
            this.richTextBox1.TabIndex = 46;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(261, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 47;
            this.label4.Text = "帮助信息";
            // 
            // idtext
            // 
            this.idtext.AutoSize = true;
            this.idtext.ForeColor = System.Drawing.Color.DimGray;
            this.idtext.Location = new System.Drawing.Point(12, 358);
            this.idtext.Name = "idtext";
            this.idtext.Size = new System.Drawing.Size(17, 12);
            this.idtext.TabIndex = 48;
            this.idtext.Text = "ID";
            // 
            // button_server
            // 
            this.button_server.BackColor = System.Drawing.Color.Transparent;
            this.button_server.BaseColor = System.Drawing.Color.DodgerBlue;
            this.button_server.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.button_server.DownBack = null;
            this.button_server.DownBaseColor = System.Drawing.Color.SkyBlue;
            this.button_server.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.button_server.ForeColor = System.Drawing.Color.White;
            this.button_server.IsDrawBorder = false;
            this.button_server.IsDrawGlass = false;
            this.button_server.Location = new System.Drawing.Point(162, 194);
            this.button_server.MouseBack = null;
            this.button_server.MouseBaseColor = System.Drawing.Color.DeepSkyBlue;
            this.button_server.Name = "button_server";
            this.button_server.NormlBack = null;
            this.button_server.Radius = 4;
            this.button_server.Size = new System.Drawing.Size(38, 21);
            this.button_server.TabIndex = 50;
            this.button_server.Text = "服务";
            this.button_server.UseVisualStyleBackColor = false;
            this.button_server.Click += new System.EventHandler(this.skinButton7_Click);
            // 
            // receivemsg
            // 
            this.receivemsg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(59)))));
            this.receivemsg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.receivemsg.ForeColor = System.Drawing.Color.LightGray;
            this.receivemsg.ImeMode = System.Windows.Forms.ImeMode.On;
            this.receivemsg.Location = new System.Drawing.Point(12, 257);
            this.receivemsg.Name = "receivemsg";
            this.receivemsg.Size = new System.Drawing.Size(230, 87);
            this.receivemsg.TabIndex = 28;
            this.receivemsg.Text = "";
            // 
            // inputmsg
            // 
            this.inputmsg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(59)))));
            this.inputmsg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputmsg.ForeColor = System.Drawing.Color.LightGray;
            this.inputmsg.ImeMode = System.Windows.Forms.ImeMode.On;
            this.inputmsg.Location = new System.Drawing.Point(12, 101);
            this.inputmsg.Name = "inputmsg";
            this.inputmsg.Size = new System.Drawing.Size(230, 87);
            this.inputmsg.TabIndex = 2;
            this.inputmsg.Text = "消息内容";
            this.inputmsg.VScroll += new System.EventHandler(this.msg_VScroll);
            this.inputmsg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rich_KeyUp);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(255, 388);
            this.Controls.Add(this.button_server);
            this.Controls.Add(this.idtext);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button_history);
            this.Controls.Add(this.helplabel);
            this.Controls.Add(this.idlabel);
            this.Controls.Add(this.button_image);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainabel2);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.button_connect);
            this.Controls.Add(this.button_emoji);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.mainlabel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.receiveport);
            this.Controls.Add(this.receivemsg);
            this.Controls.Add(this.receiveip);
            this.Controls.Add(this.targetport);
            this.Controls.Add(this.button_send);
            this.Controls.Add(this.inputmsg);
            this.Controls.Add(this.targetip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UDP测试工具";
            this.Load += new System.EventHandler(this.UDPForm1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UDPForm1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UDPForm1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox targetip;
        private MSGTool.GifRichTextBox inputmsg;
        private CCWin.SkinControl.SkinButton button_send;
        private System.Windows.Forms.TextBox targetport;
        private System.Windows.Forms.TextBox receiveport;
        private new MSGTool.GifRichTextBox receivemsg;
        private System.Windows.Forms.TextBox receiveip;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label mainlabel1;
        private CCWin.SkinControl.SkinButton CloseButton;
        private CCWin.SkinControl.SkinButton button_emoji;
        private CCWin.SkinControl.SkinButton button_connect;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label mainabel2;
        private System.Windows.Forms.Panel panel1;
        private CCWin.SkinControl.SkinButton button_image;
        private System.Windows.Forms.Label idlabel;
        private System.Windows.Forms.Label helplabel;
        private CCWin.SkinControl.SkinButton button_history;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label idtext;
        private CCWin.SkinControl.SkinButton button_server;
    }
}

