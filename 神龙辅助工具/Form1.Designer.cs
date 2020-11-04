namespace 神龙辅助工具
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timerMsg = new System.Windows.Forms.Timer(this.components);
            this.panelScreen = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tspMain = new System.Windows.Forms.ToolStripButton();
            this.tspSetAppName = new System.Windows.Forms.ToolStripButton();
            this.tspUrl = new System.Windows.Forms.ToolStripButton();
            this.tspCSDN = new System.Windows.Forms.ToolStripButton();
            this.tspQQ = new System.Windows.Forms.ToolStripButton();
            this.tspCreateWindowUser = new System.Windows.Forms.ToolStripButton();
            this.tspChangeUser = new System.Windows.Forms.ToolStripButton();
            this.panelMain = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerMsg
            // 
            this.timerMsg.Enabled = true;
            this.timerMsg.Tick += new System.EventHandler(this.timerMsg_Tick);
            // 
            // panelScreen
            // 
            this.panelScreen.ForeColor = System.Drawing.SystemColors.GrayText;
            this.panelScreen.Location = new System.Drawing.Point(5, 397);
            this.panelScreen.Name = "panelScreen";
            this.panelScreen.Size = new System.Drawing.Size(441, 21);
            this.panelScreen.TabIndex = 30;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspMain,
            this.tspSetAppName,
            this.tspUrl,
            this.tspCSDN,
            this.tspQQ,
            this.tspCreateWindowUser,
            this.tspChangeUser});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(450, 30);
            this.toolStrip1.TabIndex = 31;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tspMain
            // 
            this.tspMain.Image = ((System.Drawing.Image)(resources.GetObject("tspMain.Image")));
            this.tspMain.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspMain.Name = "tspMain";
            this.tspMain.Size = new System.Drawing.Size(68, 27);
            this.tspMain.Text = "主界面";
            this.tspMain.Click += new System.EventHandler(this.tspMain_Click);
            // 
            // tspSetAppName
            // 
            this.tspSetAppName.Image = ((System.Drawing.Image)(resources.GetObject("tspSetAppName.Image")));
            this.tspSetAppName.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspSetAppName.Name = "tspSetAppName";
            this.tspSetAppName.Size = new System.Drawing.Size(92, 27);
            this.tspSetAppName.Text = "程序重命名";
            this.tspSetAppName.Click += new System.EventHandler(this.tspSetAppName_Click);
            // 
            // tspUrl
            // 
            this.tspUrl.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tspUrl.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tspUrl.Image = ((System.Drawing.Image)(resources.GetObject("tspUrl.Image")));
            this.tspUrl.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspUrl.Name = "tspUrl";
            this.tspUrl.Size = new System.Drawing.Size(24, 27);
            this.tspUrl.Text = "官方网站";
            this.tspUrl.Click += new System.EventHandler(this.tspUrl_Click);
            // 
            // tspCSDN
            // 
            this.tspCSDN.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tspCSDN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tspCSDN.Image = ((System.Drawing.Image)(resources.GetObject("tspCSDN.Image")));
            this.tspCSDN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspCSDN.Name = "tspCSDN";
            this.tspCSDN.Size = new System.Drawing.Size(24, 27);
            this.tspCSDN.Text = "CSDN博客";
            this.tspCSDN.Click += new System.EventHandler(this.tspCSDN_Click);
            // 
            // tspQQ
            // 
            this.tspQQ.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tspQQ.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tspQQ.Image = ((System.Drawing.Image)(resources.GetObject("tspQQ.Image")));
            this.tspQQ.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspQQ.Name = "tspQQ";
            this.tspQQ.Size = new System.Drawing.Size(24, 27);
            this.tspQQ.Text = "技术QQ";
            this.tspQQ.Click += new System.EventHandler(this.tspQQ_Click);
            // 
            // tspCreateWindowUser
            // 
            this.tspCreateWindowUser.Image = ((System.Drawing.Image)(resources.GetObject("tspCreateWindowUser.Image")));
            this.tspCreateWindowUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspCreateWindowUser.Name = "tspCreateWindowUser";
            this.tspCreateWindowUser.Size = new System.Drawing.Size(80, 27);
            this.tspCreateWindowUser.Text = "创建用户";
            this.tspCreateWindowUser.Visible = false;
            this.tspCreateWindowUser.Click += new System.EventHandler(this.tspCreateWindowUser_Click);
            // 
            // tspChangeUser
            // 
            this.tspChangeUser.Image = ((System.Drawing.Image)(resources.GetObject("tspChangeUser.Image")));
            this.tspChangeUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspChangeUser.Name = "tspChangeUser";
            this.tspChangeUser.Size = new System.Drawing.Size(80, 27);
            this.tspChangeUser.Text = "切换用户";
            this.tspChangeUser.Visible = false;
            this.tspChangeUser.Click += new System.EventHandler(this.tspChangeUser_Click);
            // 
            // panelMain
            // 
            this.panelMain.Location = new System.Drawing.Point(5, 33);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(441, 364);
            this.panelMain.TabIndex = 32;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(450, 427);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panelScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "神龙辅助工具";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerMsg;
        private System.Windows.Forms.Panel panelScreen;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tspSetAppName;
        private System.Windows.Forms.ToolStripButton tspCreateWindowUser;
        private System.Windows.Forms.ToolStripButton tspUrl;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.ToolStripButton tspMain;
        private System.Windows.Forms.ToolStripButton tspChangeUser;
        private System.Windows.Forms.ToolStripButton tspQQ;
        private System.Windows.Forms.ToolStripButton tspCSDN;
    }
}

