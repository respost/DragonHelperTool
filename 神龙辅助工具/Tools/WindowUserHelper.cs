using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.DirectoryServices;

namespace 神龙辅助工具
{
    /// <summary>
    /// 计算机用户和组操作辅助类
    /// </summary>
    class WindowUserHelper
    {
        private static readonly string PATH = "WinNT://" + Environment.MachineName;
        /// <summary>
        /// 添加windows用户
        /// </summary>
        /// <param name="username">用户名</param>
        /// <param name="password">密码</param>
        /// <param name="group">所属组</param>
        /// <param name="description">描述</param>
        public static void AddUser(string username, string password, string group ="Users", string description="新增管理员用户")
        {
            using (DirectoryEntry dir = new DirectoryEntry(PATH))
            {
                using (DirectoryEntry user = dir.Children.Add(username, "User")) //增加用户名
                {
                    user.Properties["FullName"].Add(username); //用户全称
                    user.Invoke("SetPassword", password); //用户密码
                    user.Invoke("Put", "Description", description);//用户详细描述
                    //user.Invoke("Put","PasswordExpired",1); //用户下次登录需更改密码
                    user.Invoke("Put", "UserFlags", 66049); //密码永不过期
                    //user.Invoke("Put", "UserFlags", 0x0040);//用户不能更改密码s
                    user.CommitChanges();//保存用户
                    using (DirectoryEntry grp = dir.Children.Find(group, "group"))
                    {
                        if (grp.Name != "")
                        {
                            grp.Invoke("Add", user.Path.ToString());//将用户添加到某组
                        }
                    }
                }
            }
        }
        /// <summary>
        /// 更改windows用户密码
        /// </summary>
        /// <param name="username">用户名</param>
        /// <param name="newpassword">新密码</param>
        public static void UpdateUserPassword(string username, string newpassword)
        {
            using (DirectoryEntry dir = new DirectoryEntry(PATH))
            {
                using (DirectoryEntry user = dir.Children.Find(username, "user"))
                {
                    user.Invoke("SetPassword", new object[] { newpassword });
                    user.CommitChanges();
                }
            }
        }
        /// <summary>
        /// 删除windows用户
        /// </summary>
        /// <param name="username">用户名</param>
        public static void RemoveUser(string username)
        {
            using (DirectoryEntry dir = new DirectoryEntry(PATH))
            {
                using (DirectoryEntry user = dir.Children.Find(username, "User"))
                {
                    dir.Children.Remove(user);
                }
            }
        }
        /// <summary>
        /// 添加windows用户组
        /// </summary>
        /// <param name="groupName">组名称</param>
        /// <param name="description">描述</param>
        public static void AddGroup(string groupName, string description)
        {
            using (DirectoryEntry dir = new DirectoryEntry(PATH))
            {
                using (DirectoryEntry group = dir.Children.Add(groupName, "group"))
                {
                    group.Invoke("Put", new object[] { "Description", description });
                    group.CommitChanges();
                }
            }
        }
        /// <summary>
        /// 删除windows用户组
        /// </summary>
        /// <param name="groupName">组名称</param>
        public static void RemoveGroup(string groupName)
        {
            using (DirectoryEntry dir = new DirectoryEntry(PATH))
            {
                using (DirectoryEntry group = dir.Children.Find(groupName, "Group"))
                {
                    dir.Children.Remove(group);
                }
            }
        }
    }
}
