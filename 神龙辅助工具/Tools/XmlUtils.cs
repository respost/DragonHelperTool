using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using System.Net;

namespace 神龙辅助工具
{
    class XmlUtils
    {
        public static string GetNodeValue(string xmlUrl, string noneNmae, string key)
        {
            string result = "";
            using (XmlReader read = XmlReader.Create(xmlUrl))
            {
                while (read.Read())
                {
                    if (read.Name == noneNmae)
                    {
                        result = read.GetAttribute(key);
                        break;
                    }
                }
            }
            return result;
        }
        /// <summary>
        /// 读取xml配置文件
        /// </summary>
        /// <param name="strKey"></param>
        /// <param name="xmlFileName">xml文件路径</param>
        /// <returns></returns>
        public static string GetValueByKey(string strKey, string xmlFileName)
        {
            string result = "";
            XmlDocument doc = new XmlDocument();
            //获得配置文件的全路径
            doc.Load(xmlFileName);
            //找出名称为“add”的所有元素
            XmlNodeList nodes = doc.GetElementsByTagName("add");
            for (int i = 0; i < nodes.Count; i++)
            {
                //获得将当前元素的key属性
                XmlAttribute att = nodes[i].Attributes["key"];
                //根据元素的第一个属性来判断当前的元素是不是目标元素
                if (att.Value == strKey)
                {
                    //对目标元素中的第二个属性赋值
                    XmlAttribute zf = nodes[i].Attributes["value"];
                    result = zf.Value;
                    break;
                }
            }
            //返回Value的值
            return result.ToString();
        }
        /// <summary>
        /// 保存xml配置文件
        /// </summary>
        /// <param name="ConnenctionString"></param>
        /// <param name="strKey"></param>
        /// <param name="xmlFileName">xml文件路径</param>
        public static void SaveValueToXml(string ConnenctionString, string strKey, string xmlFileName)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlFileName);
            //找出名称为“add”的所有元素
            XmlNodeList nodes = doc.GetElementsByTagName("add");
            for (int i = 0; i < nodes.Count; i++)
            {
                //获得将当前元素的key属性
                XmlAttribute att = nodes[i].Attributes["key"];
                //根据元素的第一个属性来判断当前的元素是不是目标元素
                if (att.Value == strKey)
                {
                    //对目标元素中的第二个属性赋值
                    att = nodes[i].Attributes["value"];
                    att.Value = ConnenctionString;
                    break;
                }
            }
            //保存上面的修改
            doc.Save(xmlFileName);
        }
    }
}
