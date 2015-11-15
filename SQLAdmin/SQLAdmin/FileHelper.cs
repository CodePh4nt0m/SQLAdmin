using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace SQLAdmin
{
    public class FileHelper
    {
        public void SaveVersionScript(string query)
        {
            string dirname = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString();
            string path = Application.StartupPath + "\\GeneratedScripts\\" + dirname;
            Directory.CreateDirectory(path);
            //TextWriter tw = new StreamWriter(path + "\\" + dirname + ".sql", true);
            //tw.WriteLine(query);
            //tw.Close();
            System.IO.File.WriteAllText(path + "\\" + dirname + ".sql", query);
        }

        public void SaveStoredProcedure(string query,string spname)
        {
            string dirname = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString();
            string path = Application.StartupPath + "\\GeneratedScripts\\" + dirname + "\\StoredProcedures";
            Directory.CreateDirectory(path);
            string finalquery = SPHelper.GenerateIndividualScript(spname, query);
            System.IO.File.WriteAllText(path + "\\" + spname + ".sql", finalquery);
        }
    }
}
