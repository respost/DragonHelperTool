using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;

namespace 神龙辅助工具
{
    class FormPositionHelper
    {
        // 在HKEY_CURRENT_USER 设置注册表的路径  
        public static string RegPath = @"Software\Tool\ShenLong";
        public static void SaveSize(System.Windows.Forms.Form frm)
        {
            try
            {
                RegistryKey key;
                key = Registry.LocalMachine.CreateSubKey(RegPath + frm.Name);
                key.SetValue("Height", frm.Height);
                key.SetValue("Width", frm.Width);
                key.SetValue("Left", frm.Left);
                key.SetValue("Top", frm.Top);
            }
            catch (Exception)
            {
            }
        }
        public static void SetSize(System.Windows.Forms.Form frm)
        {
            //OpenSubKey第二个参数可以设置注册表的访问权限，如果需要项的写访问权限，请设置为True 
            try
            {
                RegistryKey key;
                key = Registry.LocalMachine.OpenSubKey(RegPath + frm.Name, true);
                if (key != null)
                {
                    frm.Height = (int)key.GetValue("Height");
                    frm.Width = (int)key.GetValue("Width");
                    frm.Left = (int)key.GetValue("Left");
                    frm.Top = (int)key.GetValue("Top");
                }
            }
            catch (Exception)
            {
            }
        } 
    }
}
