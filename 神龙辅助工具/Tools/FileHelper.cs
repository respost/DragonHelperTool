using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 神龙辅助工具
{
    /// <summary>
    /// 文件操作辅助类
    /// </summary>
    static class FileHelper
    {
        /// <summary>
        /// 读文件
        /// </summary>
        /// <param name="fullName">文件名</param>
        /// <returns>文件内容</returns>
        public static List<string> ReadAllText(string fullName)
        {
            return System.IO.File.ReadLines(fullName, Encoding.Default).ToList<string>();
        }

        /// <summary>
        /// 写文件
        /// </summary>
        /// <param name="fullName">文件名</param>
        /// <param name="content">待写内容</param>
        public static void WriteAllText(string fullName, List<string> content)
        {
            System.IO.File.WriteAllLines(fullName, content.ToArray<string>(), Encoding.Default);
        }
    }
}
