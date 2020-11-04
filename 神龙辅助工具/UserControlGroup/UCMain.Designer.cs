namespace 神龙辅助工具
{
    partial class UCMain
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.labStop = new System.Windows.Forms.Label();
            this.labPlay = new System.Windows.Forms.Label();
            this.labRecord = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnStopSet = new System.Windows.Forms.Button();
            this.textPlay = new System.Windows.Forms.TextBox();
            this.btnPlaySet = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRecordSet = new System.Windows.Forms.Button();
            this.textRecord = new System.Windows.Forms.TextBox();
            this.textStop = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.labReSet = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.checkBoxLoopRun = new System.Windows.Forms.CheckBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.labXY = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnRightDoubleClick = new System.Windows.Forms.RadioButton();
            this.rbtnRightClick = new System.Windows.Forms.RadioButton();
            this.rbtnLeftDoubleClick = new System.Windows.Forms.RadioButton();
            this.rbtnLeftClick = new System.Windows.Forms.RadioButton();
            this.lbTigs = new System.Windows.Forms.Label();
            this.checkBoxHotKeys = new System.Windows.Forms.CheckBox();
            this.label33 = new System.Windows.Forms.Label();
            this.trackBarSpeed = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labKey = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.textKey = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.numbeSeconds = new System.Windows.Forms.NumericUpDown();
            this.cbIsUseKey = new System.Windows.Forms.CheckBox();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numbeSeconds)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(9, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 30;
            this.label2.Text = "鼠标坐标：";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.labStop);
            this.groupBox4.Controls.Add(this.labPlay);
            this.groupBox4.Controls.Add(this.labRecord);
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox4.Location = new System.Drawing.Point(3, 164);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(242, 104);
            this.groupBox4.TabIndex = 39;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "使用说明";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(215, 12);
            this.label9.TabIndex = 2;
            this.label9.Text = "脚本参数：X轴坐标|Y轴坐标|模式|速率";
            // 
            // labStop
            // 
            this.labStop.AutoSize = true;
            this.labStop.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labStop.Location = new System.Drawing.Point(14, 62);
            this.labStop.Name = "labStop";
            this.labStop.Size = new System.Drawing.Size(71, 12);
            this.labStop.TabIndex = 0;
            this.labStop.Text = "F7 停止播放";
            // 
            // labPlay
            // 
            this.labPlay.AutoSize = true;
            this.labPlay.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labPlay.Location = new System.Drawing.Point(14, 40);
            this.labPlay.Name = "labPlay";
            this.labPlay.Size = new System.Drawing.Size(119, 12);
            this.labPlay.TabIndex = 0;
            this.labPlay.Text = "F6 开始播放脚本动作";
            // 
            // labRecord
            // 
            this.labRecord.AutoSize = true;
            this.labRecord.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labRecord.Location = new System.Drawing.Point(14, 19);
            this.labRecord.Name = "labRecord";
            this.labRecord.Size = new System.Drawing.Size(83, 12);
            this.labRecord.TabIndex = 0;
            this.labRecord.Text = "F5 设置坐标点";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnStopSet);
            this.groupBox3.Controls.Add(this.textPlay);
            this.groupBox3.Controls.Add(this.btnPlaySet);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.btnRecordSet);
            this.groupBox3.Controls.Add(this.textRecord);
            this.groupBox3.Controls.Add(this.textStop);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox3.Location = new System.Drawing.Point(3, 164);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(242, 104);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "热键设置";
            this.groupBox3.Visible = false;
            // 
            // btnStopSet
            // 
            this.btnStopSet.Location = new System.Drawing.Point(187, 73);
            this.btnStopSet.Name = "btnStopSet";
            this.btnStopSet.Size = new System.Drawing.Size(45, 21);
            this.btnStopSet.TabIndex = 2;
            this.btnStopSet.Text = "设定";
            this.btnStopSet.UseVisualStyleBackColor = true;
            this.btnStopSet.Click += new System.EventHandler(this.btnStopSet_Click);
            // 
            // textPlay
            // 
            this.textPlay.Location = new System.Drawing.Point(56, 47);
            this.textPlay.Name = "textPlay";
            this.textPlay.Size = new System.Drawing.Size(118, 21);
            this.textPlay.TabIndex = 1;
            this.textPlay.Text = "F6";
            this.textPlay.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textPlay_KeyUp);
            // 
            // btnPlaySet
            // 
            this.btnPlaySet.Location = new System.Drawing.Point(187, 47);
            this.btnPlaySet.Name = "btnPlaySet";
            this.btnPlaySet.Size = new System.Drawing.Size(45, 21);
            this.btnPlaySet.TabIndex = 2;
            this.btnPlaySet.Text = "设定";
            this.btnPlaySet.UseVisualStyleBackColor = true;
            this.btnPlaySet.Click += new System.EventHandler(this.btnPlaySet_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(12, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "录制：";
            // 
            // btnRecordSet
            // 
            this.btnRecordSet.Location = new System.Drawing.Point(187, 19);
            this.btnRecordSet.Name = "btnRecordSet";
            this.btnRecordSet.Size = new System.Drawing.Size(45, 21);
            this.btnRecordSet.TabIndex = 2;
            this.btnRecordSet.Text = "设定";
            this.btnRecordSet.UseVisualStyleBackColor = true;
            this.btnRecordSet.Click += new System.EventHandler(this.btnRecordSet_Click);
            // 
            // textRecord
            // 
            this.textRecord.Location = new System.Drawing.Point(56, 19);
            this.textRecord.Name = "textRecord";
            this.textRecord.Size = new System.Drawing.Size(118, 21);
            this.textRecord.TabIndex = 1;
            this.textRecord.Text = "F5";
            this.textRecord.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textRecord_KeyUp);
            // 
            // textStop
            // 
            this.textStop.Location = new System.Drawing.Point(56, 73);
            this.textStop.Name = "textStop";
            this.textStop.Size = new System.Drawing.Size(118, 21);
            this.textStop.TabIndex = 1;
            this.textStop.Text = "F7";
            this.textStop.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textStop_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(12, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "播放：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(11, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "停止：";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.labReSet);
            this.groupBox5.Controls.Add(this.listBox1);
            this.groupBox5.Controls.Add(this.btnExport);
            this.groupBox5.Controls.Add(this.checkBoxLoopRun);
            this.groupBox5.Controls.Add(this.btnImport);
            this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox5.Location = new System.Drawing.Point(254, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(180, 264);
            this.groupBox5.TabIndex = 40;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "脚本集合";
            // 
            // labReSet
            // 
            this.labReSet.AutoSize = true;
            this.labReSet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labReSet.Location = new System.Drawing.Point(112, 213);
            this.labReSet.Name = "labReSet";
            this.labReSet.Size = new System.Drawing.Size(53, 12);
            this.labReSet.TabIndex = 32;
            this.labReSet.Text = "重置坐标";
            this.labReSet.Click += new System.EventHandler(this.labReSet_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Control;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(9, 20);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(162, 184);
            this.listBox1.TabIndex = 0;
            this.listBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listBox1_KeyUp);
            // 
            // btnExport
            // 
            this.btnExport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExport.Location = new System.Drawing.Point(106, 233);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(65, 21);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "导出脚本";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // checkBoxLoopRun
            // 
            this.checkBoxLoopRun.AutoSize = true;
            this.checkBoxLoopRun.Checked = true;
            this.checkBoxLoopRun.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLoopRun.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkBoxLoopRun.Location = new System.Drawing.Point(9, 209);
            this.checkBoxLoopRun.Name = "checkBoxLoopRun";
            this.checkBoxLoopRun.Size = new System.Drawing.Size(72, 16);
            this.checkBoxLoopRun.TabIndex = 30;
            this.checkBoxLoopRun.Text = "循环执行";
            this.checkBoxLoopRun.UseVisualStyleBackColor = true;
            // 
            // btnImport
            // 
            this.btnImport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnImport.Location = new System.Drawing.Point(9, 233);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(65, 21);
            this.btnImport.TabIndex = 1;
            this.btnImport.Text = "导入脚本";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // labXY
            // 
            this.labXY.AutoSize = true;
            this.labXY.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labXY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labXY.Location = new System.Drawing.Point(80, 2);
            this.labXY.Name = "labXY";
            this.labXY.Size = new System.Drawing.Size(28, 14);
            this.labXY.TabIndex = 31;
            this.labXY.Text = "0,0";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label31.Location = new System.Drawing.Point(224, 59);
            this.label31.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(17, 12);
            this.label31.TabIndex = 37;
            this.label31.Text = "慢";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnRightDoubleClick);
            this.groupBox2.Controls.Add(this.rbtnRightClick);
            this.groupBox2.Controls.Add(this.rbtnLeftDoubleClick);
            this.groupBox2.Controls.Add(this.rbtnLeftClick);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox2.Location = new System.Drawing.Point(2, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 67);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "鼠标模式";
            // 
            // rbtnRightDoubleClick
            // 
            this.rbtnRightDoubleClick.AutoSize = true;
            this.rbtnRightDoubleClick.Location = new System.Drawing.Point(138, 42);
            this.rbtnRightDoubleClick.Name = "rbtnRightDoubleClick";
            this.rbtnRightDoubleClick.Size = new System.Drawing.Size(71, 16);
            this.rbtnRightDoubleClick.TabIndex = 7;
            this.rbtnRightDoubleClick.Text = "右键双击";
            this.rbtnRightDoubleClick.UseVisualStyleBackColor = true;
            // 
            // rbtnRightClick
            // 
            this.rbtnRightClick.AutoSize = true;
            this.rbtnRightClick.Location = new System.Drawing.Point(138, 20);
            this.rbtnRightClick.Name = "rbtnRightClick";
            this.rbtnRightClick.Size = new System.Drawing.Size(71, 16);
            this.rbtnRightClick.TabIndex = 6;
            this.rbtnRightClick.Text = "右键单击";
            this.rbtnRightClick.UseVisualStyleBackColor = true;
            // 
            // rbtnLeftDoubleClick
            // 
            this.rbtnLeftDoubleClick.AutoSize = true;
            this.rbtnLeftDoubleClick.Location = new System.Drawing.Point(36, 42);
            this.rbtnLeftDoubleClick.Name = "rbtnLeftDoubleClick";
            this.rbtnLeftDoubleClick.Size = new System.Drawing.Size(71, 16);
            this.rbtnLeftDoubleClick.TabIndex = 5;
            this.rbtnLeftDoubleClick.Text = "左键双击";
            this.rbtnLeftDoubleClick.UseVisualStyleBackColor = true;
            // 
            // rbtnLeftClick
            // 
            this.rbtnLeftClick.AutoSize = true;
            this.rbtnLeftClick.Checked = true;
            this.rbtnLeftClick.Location = new System.Drawing.Point(35, 20);
            this.rbtnLeftClick.Name = "rbtnLeftClick";
            this.rbtnLeftClick.Size = new System.Drawing.Size(71, 16);
            this.rbtnLeftClick.TabIndex = 4;
            this.rbtnLeftClick.TabStop = true;
            this.rbtnLeftClick.Text = "左键单击";
            this.rbtnLeftClick.UseVisualStyleBackColor = true;
            // 
            // lbTigs
            // 
            this.lbTigs.AutoSize = true;
            this.lbTigs.ForeColor = System.Drawing.Color.Red;
            this.lbTigs.Location = new System.Drawing.Point(93, 59);
            this.lbTigs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTigs.Name = "lbTigs";
            this.lbTigs.Size = new System.Drawing.Size(71, 12);
            this.lbTigs.TabIndex = 36;
            this.lbTigs.Text = "当前速率1秒";
            // 
            // checkBoxHotKeys
            // 
            this.checkBoxHotKeys.AutoSize = true;
            this.checkBoxHotKeys.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkBoxHotKeys.Location = new System.Drawing.Point(176, 2);
            this.checkBoxHotKeys.Name = "checkBoxHotKeys";
            this.checkBoxHotKeys.Size = new System.Drawing.Size(72, 16);
            this.checkBoxHotKeys.TabIndex = 33;
            this.checkBoxHotKeys.Text = "热键设置";
            this.checkBoxHotKeys.UseVisualStyleBackColor = true;
            this.checkBoxHotKeys.CheckedChanged += new System.EventHandler(this.checkBoxHotKeys_CheckedChanged);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label33.Location = new System.Drawing.Point(10, 94);
            this.label33.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(17, 12);
            this.label33.TabIndex = 35;
            this.label33.Text = "快";
            // 
            // trackBarSpeed
            // 
            this.trackBarSpeed.LargeChange = 1;
            this.trackBarSpeed.Location = new System.Drawing.Point(8, 26);
            this.trackBarSpeed.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarSpeed.Maximum = 300;
            this.trackBarSpeed.Minimum = 1;
            this.trackBarSpeed.Name = "trackBarSpeed";
            this.trackBarSpeed.Size = new System.Drawing.Size(237, 45);
            this.trackBarSpeed.TabIndex = 34;
            this.trackBarSpeed.TickFrequency = 20;
            this.trackBarSpeed.Value = 5;
            this.trackBarSpeed.ValueChanged += new System.EventHandler(this.trackBarSpeed_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(15, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 37;
            this.label1.Text = "快";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labKey);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.textKey);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.numbeSeconds);
            this.groupBox1.Controls.Add(this.cbIsUseKey);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(3, 274);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 86);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "键盘动作";
            // 
            // labKey
            // 
            this.labKey.AutoSize = true;
            this.labKey.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labKey.Location = new System.Drawing.Point(91, 21);
            this.labKey.Name = "labKey";
            this.labKey.Size = new System.Drawing.Size(21, 14);
            this.labKey.TabIndex = 15;
            this.labKey.Text = "D2";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Crimson;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSave.Location = new System.Drawing.Point(298, 52);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(63, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "保存设置";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // textKey
            // 
            this.textKey.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textKey.Location = new System.Drawing.Point(179, 52);
            this.textKey.Name = "textKey";
            this.textKey.Size = new System.Drawing.Size(99, 23);
            this.textKey.TabIndex = 12;
            this.textKey.Text = "2";
            this.textKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textKey.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textKey_KeyUp);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(71, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 14);
            this.label11.TabIndex = 11;
            this.label11.Text = "秒自动点击一次";
            // 
            // numbeSeconds
            // 
            this.numbeSeconds.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numbeSeconds.Location = new System.Drawing.Point(14, 49);
            this.numbeSeconds.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numbeSeconds.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numbeSeconds.Name = "numbeSeconds";
            this.numbeSeconds.Size = new System.Drawing.Size(54, 23);
            this.numbeSeconds.TabIndex = 10;
            this.numbeSeconds.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // cbIsUseKey
            // 
            this.cbIsUseKey.AutoSize = true;
            this.cbIsUseKey.Checked = true;
            this.cbIsUseKey.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbIsUseKey.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbIsUseKey.Location = new System.Drawing.Point(14, 20);
            this.cbIsUseKey.Name = "cbIsUseKey";
            this.cbIsUseKey.Size = new System.Drawing.Size(82, 18);
            this.cbIsUseKey.TabIndex = 8;
            this.cbIsUseKey.Text = "是否启用";
            this.cbIsUseKey.UseVisualStyleBackColor = true;
            // 
            // UCMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.labXY);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbTigs);
            this.Controls.Add(this.checkBoxHotKeys);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.trackBarSpeed);
            this.Controls.Add(this.groupBox4);
            this.Name = "UCMain";
            this.Size = new System.Drawing.Size(437, 362);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numbeSeconds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labStop;
        private System.Windows.Forms.Label labPlay;
        private System.Windows.Forms.Label labRecord;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnStopSet;
        private System.Windows.Forms.TextBox textPlay;
        private System.Windows.Forms.Button btnPlaySet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRecordSet;
        private System.Windows.Forms.TextBox textRecord;
        private System.Windows.Forms.TextBox textStop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label labReSet;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.CheckBox checkBoxLoopRun;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Label labXY;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtnRightDoubleClick;
        private System.Windows.Forms.RadioButton rbtnRightClick;
        private System.Windows.Forms.RadioButton rbtnLeftDoubleClick;
        private System.Windows.Forms.RadioButton rbtnLeftClick;
        private System.Windows.Forms.Label lbTigs;
        private System.Windows.Forms.CheckBox checkBoxHotKeys;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TrackBar trackBarSpeed;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labKey;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox textKey;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numbeSeconds;
        private System.Windows.Forms.CheckBox cbIsUseKey;
    }
}
