using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using MouseKeyboardActivityMonitor;
using System.Threading;

namespace 神龙辅助工具
{
    public partial class Form1 : Form
    {
        private string processName;//当前程序进程名
        Point mouseOff;//鼠标移动位置变量
        bool leftFlag; //标记是否为左键

        //底部文字滚动显示
        private int mPostionX, mPostionY;
        private int mHeight, mWidth;
        private Label mLabel = new Label();

        public Form1()
        {
            //加载嵌入资源（添加程序集解析事件）
            AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(CurrentDomain_AssemblyResolve);
            InitializeComponent();
            /*在多线程程序中：
             * 新创建的线程不能访问UI线程创建的窗口控件，
             * 如果需要访问窗口中的控件，可以在窗口构造函数中将CheckForIllegalCrossThreadCalls设置为false         
             */
            Control.CheckForIllegalCrossThreadCalls = false;
            /*
            //右下角显示【注意：代码要放到InitializeComponent()后面】
            int x = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Size.Width - this.Width;
            int y = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Size.Height - this.Height;
            Point p = new Point(x, y);
            this.PointToScreen(p);
            this.Location = p;
             */
        }
        //切换计算机用户
        [DllImport("Wtsapi32.dll", SetLastError = true)]
        extern static bool WTSDisconnectSession(IntPtr hServer, int sessionId, [MarshalAs(UnmanagedType.Bool)] bool bWait);

        #region 加载嵌入资源中的全部dll文件
        private System.Reflection.Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            string dllName = args.Name.Contains(",") ? args.Name.Substring(0, args.Name.IndexOf(',')) : args.Name.Replace(".dll", "");
            dllName = dllName.Replace(".", "_");
            if (dllName.EndsWith("_resources")) return null;
            System.Resources.ResourceManager rm = new System.Resources.ResourceManager(GetType().Namespace + ".Properties.Resources", System.Reflection.Assembly.GetExecutingAssembly());
            byte[] bytes = (byte[])rm.GetObject(dllName);
            return System.Reflection.Assembly.Load(bytes);
        }
        #endregion

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y); //得到变量的值
                leftFlag = true; //点击左键按下时标注为true
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);  //设置移动后的位置
                Location = mouseSet;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;//释放鼠标后标注为false
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //获取当前进程名称
            Process cur = Process.GetCurrentProcess();
            processName = cur.ProcessName;
            this.Text = processName;
            FormPositionHelper.SetSize(this);
            //加载主面板
            ShowMain();
            //显示底部滚动信息
            InitScrollShow();
        }

        private void ShowMain()
        {
            panelMain.Controls.Clear();
            UCMain uc = new UCMain();
            //设置样式是否填充整个panel
            uc.Dock = System.Windows.Forms.DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //必须加上这个判断，否则窗体最小化后无法恢复和还原了
            if (this.WindowState != FormWindowState.Minimized)
                FormPositionHelper.SaveSize(this);
        }

        // 初始化label显示
        private void InitScrollShow()
        {
            mHeight = panelScreen.Height; ;
            mWidth = panelScreen.Width;
            mLabel.Font = new Font("宋体", 9);
            //label显示需要减去本身的高度
            mHeight -= mLabel.Font.Height;  
            mPostionX = mWidth;
            mPostionY = mHeight;
            mLabel.Location = new Point(mPostionX, mPostionY);
            mLabel.Text = "提示：使用鼠标选中脚本项，按Delete键可直接删除该脚本。 开发团队：美奇软件开发工作室 联系QQ：15577969";
            mLabel.ForeColor = Color.OrangeRed;
            mLabel.AutoSize = true;
            panelScreen.Controls.Add(mLabel);
            mLabel.Visible = true;
        }

        // 设置底栏从右向左滚动显示
        private void ScrollShow()
        {
            mPostionX = mPostionX - 3;
            mLabel.Location = new Point(mPostionX, mPostionY);
            if (mPostionX <= -mLabel.Size.Width)
            {
                mPostionX = mWidth;
            }
            mLabel.Visible = true;
        }

        private void timerMsg_Tick(object sender, EventArgs e)
        {
            ScrollShow();
        }

        private void tspSetAppName_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            UCReName uc = new UCReName();
            //设置样式是否填充整个panel
            uc.Dock = System.Windows.Forms.DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void tspMain_Click(object sender, EventArgs e)
        {
            ShowMain();
        }

        private void tspCreateWindowUser_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            UCWindowAccount uc = new UCWindowAccount();
            //设置样式是否填充整个panel
            uc.Dock = System.Windows.Forms.DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void tspChangeUser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要切换到其他用户吗?", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)

            {
                //使用子线程去切换，防止电脑卡顿。
                new Thread(new ThreadStart(this.ChangeWindowUser)) { IsBackground = true }.Start();
            }
                 
        }
        private void ChangeWindowUser()
        {
            IntPtr WTS_CURRENT_SERVER_HANDLE = IntPtr.Zero;
            int WTS_CURRENT_SESSION = -1;

            if (!WTSDisconnectSession(WTS_CURRENT_SERVER_HANDLE, WTS_CURRENT_SESSION, false))
            {
                MessageBox.Show("WTSDisconnectSession Failed: " + Marshal.GetLastWin32Error());
            }
        }

        private void tspQQ_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("tencent://message/?uin=15577969&amp;Menu=yes");
            }
            catch (Exception)
            {
                Process.Start("https://wpa.qq.com/msgrd?v=3&uin=15577969&site=qqq&menu=yes");
            }
        }

        private void tspUrl_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.zy13.net");
        }

        private void tspCSDN_Click(object sender, EventArgs e)
        {
            Process.Start("https://blog.csdn.net/qq15577969");
        }

    }
}
