using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MouseKeyboardActivityMonitor;
using System.Threading;
using System.Runtime.InteropServices;

namespace 神龙辅助工具
{
    public partial class UCMain : UserControl
    {
        private int speed = 500;

        //Ini文件辅助类
        private IniHelper ini = null;

        //默认键
        Keys keyRecord = Keys.F5;
        Keys keyPlay = Keys.F6;
        Keys keyStop = Keys.F7;
        TypeConverter converter = TypeDescriptor.GetConverter(typeof(Keys));

        readonly KeyboardHookListener khl;
        readonly MouseHookListener mhl;

        //是否启用键
        bool IsUseKey = true;

        //默认键
        Keys keyItem = Keys.D2;
        //延迟时间
        int delayTime = 60;

        private Thread threadRandom;

        //操作键盘
        [DllImport("user32.dll", EntryPoint = "keybd_event", SetLastError = true)]
        public static extern void keybd_event(Keys bVk, byte bScan, uint dwFlags, uint dwExtraInfo);

        public UCMain()
        {
            InitializeComponent();
            //加载config.ini配置文件           
            LoadIniConfig();
            //设置鼠标勾子
            mhl = new MouseHookListener(new MouseKeyboardActivityMonitor.WinApi.GlobalHooker());
            mhl.MouseMove += new MouseEventHandler(mhl_MouseMove);
            mhl.Enabled = true;

            //设置键盘勾子
            khl = new KeyboardHookListener(new MouseKeyboardActivityMonitor.WinApi.GlobalHooker());
            khl.KeyDown += new KeyEventHandler(khl_KeyDown);
            khl.Enabled = true;
        }

        //实时显示鼠标坐标
        void mhl_MouseMove(object sender, MouseEventArgs e)
        {
            labXY.Text = e.X + "," + e.Y;
        }
        //判断按键
        void khl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == keyRecord)       //设置坐标点
            {
                string action = string.Empty;

                if (rbtnLeftClick.Checked) action = rbtnLeftClick.Text;         //左键单击
                else if (rbtnLeftDoubleClick.Checked) action = rbtnLeftDoubleClick.Text;   //左键双击
                else if (rbtnRightClick.Checked) action = rbtnRightClick.Text;        //右键单击
                else if (rbtnRightDoubleClick.Checked) action = rbtnRightDoubleClick.Text;  //右键双击
                string[] stringArray = labXY.Text.Trim().Split(',');
                listBox1.Items.Add(string.Format("{0}|{1}|{2}|{3}", stringArray[0], stringArray[1], action, speed));
            }
            else if (e.KeyCode == keyPlay)  //开始播放
            {
                if (listBox1.Items.Count == 0) return;
                AutoClickThread.ClickData = listBox1.Items.Cast<string>().ToList();
                AutoClickThread.Start(checkBoxLoopRun.Checked);
                //开始随机
                StartRandom();
            }
            else if (e.KeyCode == keyStop)  //停止播放
            {
                AutoClickThread.Stop();
                //停止随机
                StopRandom();
            }
        }

        /// <summary>
        /// 加载ini配置文件
        /// </summary>
        private void LoadIniConfig()
        {
            this.ini = new IniHelper("config.ini");
            string iniRecord = this.ini.ReadString("Setting", "RecordHotKey", "F5");
            this.keyRecord = (Keys)converter.ConvertFromString(iniRecord);
            this.textRecord.Text = iniRecord;
            this.labRecord.Text = iniRecord + " 设置坐标点";

            string iniPlay = this.ini.ReadString("Setting", "PlayHotKey", "F6");
            this.keyPlay = (Keys)converter.ConvertFromString(iniPlay);
            this.textPlay.Text = iniPlay;
            this.labPlay.Text = iniPlay + " 开始播放脚本动作";

            string iniStop = this.ini.ReadString("Setting", "StopHotKey", "F7");
            this.keyStop = (Keys)converter.ConvertFromString(iniStop);
            this.textStop.Text = iniStop;
            this.labStop.Text = iniStop + " 停止播放";

            //速率显示
            this.speed = this.ini.ReadInteger("Setting", "Speed", 500);
            this.trackBarSpeed.Value = speed / 100;
            showTrackBar();

            //是否启用键
            this.IsUseKey = this.ini.ReadBool("Setting", "IsUseKey", true);
            this.cbIsUseKey.Checked = this.IsUseKey;
            //获取键名
            string textKey = this.ini.ReadString("Setting", "Keyboard", "D2");
            this.keyItem = (Keys)converter.ConvertFromString(textKey);
            this.textKey.Text = textKey;
            this.labKey.Text = textKey+"键";
            //随机时间
            this.delayTime = this.ini.ReadInteger("Setting", "DelayTime", 60);
            this.numbeSeconds.Value = this.delayTime;
        }

        private void checkBoxHotKeys_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHotKeys.Checked)
            {
                groupBox3.Show();
                groupBox4.Hide();
            }
            else
            {
                groupBox3.Hide();
                groupBox4.Show();
            }
        }

        private void trackBarSpeed_ValueChanged(object sender, EventArgs e)
        {
            speed = this.trackBarSpeed.Value * 100;
            this.ini.WriteString("Setting", "Speed", speed.ToString());
            showTrackBar();
        }

        private void showTrackBar()
        {
            float f = speed * 1.0f / 1000;
            this.lbTigs.Text = "当前速率" + f + "秒";
        }

        private void listBox1_KeyUp(object sender, KeyEventArgs e)
        {
            //点击Delete删除键
            if (listBox1.SelectedIndex >= 0 && e.KeyCode == Keys.Delete)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            //ctrl+s保存快捷键
            if (e.Modifiers.CompareTo(Keys.Control) == 0 && e.KeyCode == Keys.S)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.AddExtension = true;
                sfd.Filter = "文本文件(*.txt)|*.txt";
                sfd.DefaultExt = "txt";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    FileHelper.WriteAllText(sfd.FileName, listBox1.Items.Cast<string>().ToList<string>());
                }
            }
        }

        private void labReSet_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "文本文件(*.txt)|*.txt";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                List<string> fileContent = FileHelper.ReadAllText(ofd.FileName);
                listBox1.Items.AddRange(fileContent.ToArray<string>());
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.AddExtension = true;
            sfd.Filter = "文本文件(*.txt)|*.txt";
            sfd.DefaultExt = "txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                FileHelper.WriteAllText(sfd.FileName, listBox1.Items.Cast<string>().ToList<string>());
            }
        }

        private void btnRecordSet_Click(object sender, EventArgs e)
        {
            string textRecord = this.textRecord.Text.Trim();
            keyRecord = (Keys)converter.ConvertFromString(textRecord);
            labRecord.Text = textRecord + " 设置坐标点";
            this.ini.WriteString("Setting", "RecordHotKey", textRecord);
            MessageBox.Show("录制键设置成功");
        }

        private void btnPlaySet_Click(object sender, EventArgs e)
        {
            string textPlay = this.textPlay.Text.Trim();
            keyPlay = (Keys)converter.ConvertFromString(textPlay);
            labPlay.Text = textPlay + " 开始播放脚本动作";
            this.ini.WriteString("Setting", "PlayHotKey", textPlay);
            MessageBox.Show("播放键设置成功");
        }

        private void btnStopSet_Click(object sender, EventArgs e)
        {
            string textStop = this.textStop.Text.Trim();
            keyStop = (Keys)converter.ConvertFromString(textStop);
            labStop.Text = textStop + " 停止播放";
            this.ini.WriteString("Setting", "StopHotKey", textStop);
            MessageBox.Show("停止键设置成功");
        }

        private void textRecord_KeyUp(object sender, KeyEventArgs e)
        {
            this.textRecord.Text = e.KeyCode.ToString();
        }

        private void textPlay_KeyUp(object sender, KeyEventArgs e)
        {
            this.textPlay.Text = e.KeyCode.ToString();
        }

        private void textStop_KeyUp(object sender, KeyEventArgs e)
        {
            this.textStop.Text = e.KeyCode.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //是否启用键
                this.IsUseKey = this.cbIsUseKey.Checked;
                this.ini.WriteBool("Setting", "IsUseKey", this.IsUseKey);
                //设置键名
                string textKey = this.textKey.Text.Trim();
                keyItem = (Keys)converter.ConvertFromString(textKey);
                this.ini.WriteString("Setting", "Keyboard", textKey);
                this.labKey.Text = textKey + "键";
                //随机时间
                this.delayTime = Convert.ToInt32(numbeSeconds.Value) > 0 ? Convert.ToInt32(numbeSeconds.Value) : 60;
                this.ini.WriteInteger("Setting", "DelayTime", this.delayTime);
                MessageBox.Show("保存设置成功");
            }
            catch (Exception)
            {
                MessageBox.Show("保存设置失败");
            }
        }

        private void textKey_KeyUp(object sender, KeyEventArgs e)
        {
            this.textKey.Text = e.KeyCode.ToString();
        }

        /// <summary>
        /// 开始随机
        /// </summary>
        public void StartRandom()
        {
            if (threadRandom == null)
                threadRandom = new Thread(new ThreadStart(KeyProcess));
            threadRandom.Start();
        }
        /// <summary>
        /// 停止随机
        /// </summary>
        public void StopRandom()
        {
            if (threadRandom != null)
            {
                threadRandom.Abort();
                threadRandom = null;
            }
        }
        private void KeyProcess()
        {
            while (true)
            {
                try
                {
                    //线程延迟
                    Thread.Sleep(delayTime * 1000);
                    if (IsUseKey)
                        keybd_event(this.keyItem, 0, 0, 0);
                }
                catch (Exception)
                {
                }
            }
        }
    }
}
