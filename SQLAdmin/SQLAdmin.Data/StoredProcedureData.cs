using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using SQLAdmin.Common;
using SQLAdmin.Model;
using Subtext.Scripting;

namespace SQLAdmin.Data
{
    public class StoredProcedureData
    {
        public List<StoredProcedureModel> SearchStoredProcedure(ServerModel server,string spname)
        {
            try
            {
                string query = "select SPECIFIC_NAME from " + server.Database +".information_schema.routines where routine_type = 'PROCEDURE'";
                query += " SPECIFIC_NAME LIKE '%" + spname + "%'";
                var splist = new List<StoredProcedureModel>();
                using (SqlCommand cmd = new SqlCommand(query, ConnectionManager.Connection(server)))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            splist.Add(new StoredProcedureModel() {Name = dr["SPECIFIC_NAME"].ToString()});
                        }
                        return splist;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                ConnectionManager.Close();
            }
            return null;
        }

        public string GetScript(ServerModel server, string spname)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("sys.sp_helptext", ConnectionManager.Connection(server)))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@objname", spname);
                    DataSet ds = new DataSet();
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                    sqlDataAdapter.SelectCommand = cmd;
                    sqlDataAdapter.Fill(ds);
                    return CommonHelper.DataTableToString(ds.Tables[0]); ;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                ConnectionManager.Close();
            }
            return null;
        }

        public void ExecuteQuery(ServerModel server, string query)
        {
            try
            {
                Server smoserver = new Server(new ServerConnection(ConnectionManager.Connection(server)));
                smoserver.ConnectionContext.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                ConnectionManager.Close();
            }
        }
    }
}
