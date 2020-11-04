using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace 神龙辅助工具
{
    /// <summary>
    /// 鼠标事件辅助类
    /// </summary>
    public sealed class MouseHelper
    {
        #region WinAPI

        /// <summary>
        /// 鼠标事件类型
        /// </summary>
        private enum MouseEventFlags       //鼠标按键的ASCLL码
        {
            Move = 0x0001,
            LeftDown = 0x0002,
            LeftUp = 0x0004,
            RightDown = 0x0008,
            RightUp = 0x0010,
            MiddleDown = 0x0020,
            MiddleUp = 0x0040,
            Wheel = 0x0800,
            Absolute = 0x8000
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct POINT
        {
            public int X;
            public int Y;
        }

        /// <summary>
        /// 鼠标事件
        /// </summary>
        /// <param name="dwFlags">事件类型</param>
        /// <param name="dx">X坐标</param>
        /// <param name="dy">Y坐标</param>
        /// <param name="dwData"></param>
        /// <param name="dwExtraInfo"></param>
        [DllImport("User32")]
        private extern static void mouse_event(int dwFlags, int dx, int dy, int dwData, IntPtr dwExtraInfo);

        [DllImport("User32")]
        public extern static void SetCursorPos(int x, int y);

        [DllImport("User32")]
        public extern static bool GetCursorPos(out POINT p);

        #endregion

        /// <summary>
        /// 鼠标左键单击
        /// </summary>
        /// <param name="x">X</param>
        /// <param name="y">Y</param>
        public static void LeftButtonClick(int x = 0, int y = 0)
        {
            SetCursorPos(x, y);
            mouse_event((int)(MouseEventFlags.LeftDown | MouseEventFlags.Absolute), 0, 0, 0, IntPtr.Zero);
            Thread.Sleep(100);
            mouse_event((int)(MouseEventFlags.LeftUp | MouseEventFlags.Absolute), 0, 0, 0, IntPtr.Zero);
        }

        /// <summary>
        /// 鼠标右键单击
        /// </summary>
        /// <param name="x">X</param>
        /// <param name="y">Y</param>
        public static void RightButtonClick(int x = 0, int y = 0)
        {
            SetCursorPos(x, y);
            mouse_event((int)(MouseEventFlags.RightDown | MouseEventFlags.Absolute), 0, 0, 0, IntPtr.Zero);
            Thread.Sleep(100);
            mouse_event((int)(MouseEventFlags.RightUp | MouseEventFlags.Absolute), 0, 0, 0, IntPtr.Zero);
        }

        /// <summary>
        /// 鼠标左键双击
        /// </summary>
        /// <param name="x">X</param>
        /// <param name="y">Y</param>
        public static void LeftButtonDoubleClick(int x = 0, int y = 0)
        {
            LeftButtonClick(x, y);
            Thread.Sleep(200);
            LeftButtonClick(x, y);
        }

        /// <summary>
        /// 鼠标右键双击
        /// </summary>
        /// <param name="x">X</param>
        /// <param name="y">Y</param>
        public static void RightButtonDoubleClick(int x = 0, int y = 0)
        {
            RightButtonClick(x, y);
            Thread.Sleep(200);
            RightButtonClick(x, y);
        }

    }
}
