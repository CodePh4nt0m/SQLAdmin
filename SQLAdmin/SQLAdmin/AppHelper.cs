using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLAdmin.Model;
using Microsoft.SqlServer.Management.Smo;

namespace SQLAdmin
{
    public class AppHelper
    {
        public static List<ServerModel> ServerList = null;
        public AppHelper()
        {
            
        }

        public static List<ServerModel> GetServerList()
        {
            ServerList = new List<ServerModel>();
            SqlDataSourceEnumerator instance = SqlDataSourceEnumerator.Instance;
            DataTable dt = instance.GetDataSources();
            foreach (DataRow dr in dt.Rows)
            {
                ServerList.Add(new ServerModel() {ServerName = dr["Name"].ToString()});
            }
            return ServerList;
        }

        public static string GenerateTimeId()
        {
            var id =  DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() +
              DateTime.Now.Hour.ToString() +
              DateTime.Now.Minute.ToString() +
              DateTime.Now.Second.ToString() +
              DateTime.Now.Millisecond.ToString();
            return id.ToString();
        }
    }

    public class XmlDB
    {
        public const string Environments = "xmldb\\environments.xml";
        public const string StoredProcedures = "xmldb\\sp.xml";
    }
}
