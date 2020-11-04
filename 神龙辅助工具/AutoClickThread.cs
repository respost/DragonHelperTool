using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace 神龙辅助工具
{
    /// <summary>
    /// 自动点击线程类
    /// </summary>
    static class AutoClickThread
    {
        public static List<string> ClickData;
        static CancellationTokenSource cts;

        //开始
        public static void Start(bool isRecycleRun)
        {
            if (ClickData.Count == 0) return;

            if (cts != null && !cts.IsCancellationRequested) return;
            cts = new CancellationTokenSource();
            ThreadPool.QueueUserWorkItem(new WaitCallback(Run), isRecycleRun);
        }

        //停止
        public static void Stop()
        {
            if (cts != null)
                cts.Cancel();
        }

        //执行
        static void Run(object isRecycleRun)
        {
            string[] stringArray;
            int x, y, sleepTime;

            do
            {
                foreach (string item in ClickData)
                {
                    if (cts.Token.IsCancellationRequested) return;

                    stringArray = item.Split('|');
                    x = int.Parse(stringArray[0]);
                    y = int.Parse(stringArray[1]);
                    sleepTime = int.Parse(stringArray[3]);

                    switch (stringArray[2])
                    {
                        case "左键单击": MouseHelper.LeftButtonClick(x, y); break;
                        case "左键双击": MouseHelper.LeftButtonDoubleClick(x, y); break;
                        case "右键单击": MouseHelper.RightButtonClick(x, y); break;
                        case "右键双击": MouseHelper.RightButtonDoubleClick(x, y); break;
                    }

                    Thread.Sleep(sleepTime);
                }
            }
            while ((bool)isRecycleRun);
        }
    }
}
