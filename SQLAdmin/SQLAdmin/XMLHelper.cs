using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using SQLAdmin.Model;

namespace SQLAdmin
{
    public class XMLHelper
    {
        public List<ServerModel> GetEnvironments()
        {
            List<ServerModel> envlist = new List<ServerModel>();
            XmlDataDocument xmldoc = new XmlDataDocument();
            XmlNodeList xmlnode;
            using (FileStream fs = new FileStream(XmlDB.Environments, FileMode.Open, FileAccess.Read))
            {
                xmldoc.Load(fs);
                xmlnode = xmldoc.GetElementsByTagName("env");
                for (int i = 0; i <= xmlnode.Count - 1; i++)
                {
                    envlist.Add(new ServerModel()
                    {
                        ServerID = xmlnode[i].Attributes["id"].Value,
                        ServerName = xmlnode[i].ChildNodes.Item(0).InnerText.Trim(),
                        Database = xmlnode[i].ChildNodes.Item(1).InnerText.Trim(),
                        Username = xmlnode[i].ChildNodes.Item(2).InnerText.Trim(),
                        Password = xmlnode[i].ChildNodes.Item(3).InnerText.Trim()
                    });
                }
            }
            return envlist;
        }
    }
}
