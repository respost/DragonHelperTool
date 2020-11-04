using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace 神龙辅助工具
{
    /// <summary>
    /// 批处理工具类
    /// </summary>
    class BatUtils
    {
        /// <summary>
        /// 写入bat文件
        /// </summary>
        /// <param name="fileContent"></param>
        /// <param name="filePath"></param>
        public static void writeBATFile(string fileContent, string filePath)
        {
            FileStream fs1 = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);//创建写入文件
            StreamWriter sw = new StreamWriter(fs1, Encoding.GetEncoding("GB2312"));
            sw.WriteLine(fileContent);//开始写入值
            sw.Close();
            fs1.Close();
        }
        /// <summary>
        /// 执行bat文件
        /// </summary>
        /// <param name="filePath">所在目录</param>
        /// <param name="fileName">文件名</param>
        public static bool runBATFile(string filePath, string fileName)
        {
            bool flag = false;
            Process proc = null;
            try
            {
                string targetDir = string.Format(filePath);
                proc = new Process();
                proc.StartInfo.WorkingDirectory = targetDir;
                proc.StartInfo.FileName = fileName;
                proc.StartInfo.Arguments = string.Format("10");
                proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;//这里设置DOS窗口不显示
                proc.Start();
                proc.WaitForExit();
                proc.Close();
                flag = true;
            }
            catch (Exception ex)
            {
                flag = false;
                Console.WriteLine("Exception Occurred :{0},{1}", ex.Message, ex.StackTrace.ToString());
            }
            return flag;
        }
        /// <summary>
        /// 运行cmd命令
        /// </summary>
        /// <param name="command"></param>
        public static void RunCmd(string command)
        {
            //不管命令是否成功均执行exit命令，否则当调用ReadToEnd()方法时，会处于假死状态
            //command = command.Trim().TrimEnd('&') + "&exit";
            using (Process p = new Process())
            {
                p.StartInfo.FileName = "cmd.exe";
                //是否使用操作系统shell启动
                p.StartInfo.UseShellExecute = false;
                //接受来自调用程序的输入信息
                p.StartInfo.RedirectStandardInput = true;
                //输出信息
                p.StartInfo.RedirectStandardOutput = true;
                //输出错误
                p.StartInfo.RedirectStandardError = true;
                //不显示程序窗口
                p.StartInfo.CreateNoWindow = true;
                //启动程序
                p.Start();
                //向cmd窗口发送输入信息
                p.StandardInput.AutoFlush = true;
                p.StandardInput.WriteLine(command);
                //获取cmd窗口的输出信息
                //string output = p.StandardOutput.ReadToEnd();
                p.WaitForExit();//等待程序执行完退出进程
                p.Close();
            }
        }
    }
}
