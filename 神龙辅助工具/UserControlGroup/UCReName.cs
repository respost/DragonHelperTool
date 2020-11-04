using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace 神龙辅助工具
{
    /// <summary>
    /// 用户控件：自定义程序名
    /// </summary>
    public partial class UCReName : UserControl
    {
        public UCReName()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string appName = txtAppName.Text.Trim();
            if (appName == string.Empty)
            {
                MessageBox.Show("请输入程序名称");
                return;
            }
            if (!appName.Contains(".exe"))
                appName += ".exe";
            string newFilePath = Environment.CurrentDirectory + "//" + appName;
            //获取当前进程名称
            Process cur = Process.GetCurrentProcess();
            string processName = cur.ProcessName;
            //正在运行的程序路径和文件名
            string oldFilePath = Application.ExecutablePath;
            string appBat = String.Format(@"
            @echo off
            taskkill /f /im {0}
            ren {0} {1}
            del /q /f {2} 
            start {3}", processName + ".exe", appName, oldFilePath, newFilePath);
            BatUtils.writeBATFile(appBat, "修改进程名.bat");
            //隐藏文件          
            FileInfo fi = new FileInfo(Environment.CurrentDirectory + "\\修改进程名.bat");
            fi.Attributes = fi.Attributes | FileAttributes.Hidden;
            if (File.Exists("修改进程名.bat"))
            {
                BatUtils.runBATFile(Environment.CurrentDirectory, "修改进程名.bat");
            }
        }
    }
}
