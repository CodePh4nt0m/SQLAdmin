using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLAdmin.Data;

namespace SQLAdmin
{
    public class SPHelper
    {
        public static string DropQuery(string spname)
        {
            string query = "IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].["+spname+"]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)" + Environment.NewLine+
                           "DROP PROCEDURE [dbo].["+ spname +"]" + Environment.NewLine +
                           "" + Environment.NewLine+
                           "/****** Object:  StoredProcedure [dbo].[" + spname + "]    Script Date: " +
                           DateTime.Now.ToString("dd-MM-yy hh:mm:ss tt") + " ******/" + Environment.NewLine +
                           "SET ANSI_NULLS ON" + Environment.NewLine +
                           "GO" + Environment.NewLine +
                           "SET QUOTED_IDENTIFIER ON" + Environment.NewLine +
                           "GO" + Environment.NewLine + Environment.NewLine;
            return query;

        }


        public static string GenerateIndividualScript(string spname, string query)
        {
            string dropquery = DropQuery(spname);
            string script = dropquery + query + Environment.NewLine + Environment.NewLine + "GO" + Environment.NewLine + Environment.NewLine + Environment.NewLine;
            return script;
        }

        public string GenerateVersionScript(List<string> splist)
        {
            StoredProcedureData spdata=  new StoredProcedureData();
            string ver_script = "";
            foreach (var spname in splist)
            {
                string dropquery = DropQuery(spname);
                string script = dropquery + spdata.GetScript(null,spname).Trim() + Environment.NewLine + Environment.NewLine + "GO" + Environment.NewLine + Environment.NewLine + Environment.NewLine
                    + Environment.NewLine + Environment.NewLine + Environment.NewLine; ;
                ver_script += script;
            }
            return ver_script;
        }
    }
}
