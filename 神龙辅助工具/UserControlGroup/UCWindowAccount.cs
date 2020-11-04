using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace 神龙辅助工具
{
    public partial class UCWindowAccount : UserControl
    {
        public UCWindowAccount()
        {
            InitializeComponent();
            /*在多线程程序中：
             * 新创建的线程不能访问UI线程创建的窗口控件，
             * 如果需要访问窗口中的控件，可以在窗口构造函数中将CheckForIllegalCrossThreadCalls设置为false         
             */
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (this.btnCreate.Text == "创建用户")
            {
                string userName = textUserName.Text.Trim();
                if (userName == string.Empty)
                {
                    MessageBox.Show("请输入用户名");
                    return;
                }
                string password = textPassword.Text.Trim();
                if (password == string.Empty)
                {
                    MessageBox.Show("请输入登录密码");
                    return;
                }
                this.btnCreate.Text = "请稍候，正在创建...";
                // 使用子线程去创建，防止界面卡顿。
                new Thread(new ThreadStart(this.PerformTask)) { IsBackground = true }.Start();
                
            }
        }
        private void PerformTask()
        {
            try
            {
                string userName = textUserName.Text.Trim();
                string password = textPassword.Text.Trim();
                WindowUserHelper.AddUser(userName, password);
                MessageBox.Show("创建用户成功");
                this.btnCreate.Text = "创建用户";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.btnCreate.Text = "创建用户";
            }
        }

    }
}
