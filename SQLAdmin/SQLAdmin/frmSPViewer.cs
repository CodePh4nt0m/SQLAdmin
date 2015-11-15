using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ColorCode;
using SQLAdmin.Common;
using SQLAdmin.Data;
using SQLAdmin.Model;

namespace SQLAdmin
{
    public partial class frmSPViewer : Form
    {
        private string _script = "";
        private List<ServerModel> _envlist = null;
        private StoredProcedureData spdata = null;
        public frmSPViewer(string script)
        {
            InitializeComponent();
            _script = script;
            _envlist = new List<ServerModel>();
        }

        private void frmSPViewer_Load(object sender, EventArgs e)
        {
            try
            {
                txtSyntacBox.Text = _script;
                LoadEnvironments();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }          
        }

        private void LoadEnvironments()
        {
            XMLHelper xmlHelper = new XMLHelper();
            var serverlist = xmlHelper.GetEnvironments();
            if (serverlist != null)
            {
                _envlist = serverlist;
                foreach (var s in serverlist)
                {
                    ToolStripItem item = new ToolStripMenuItem();
                    item.Text = s.Database;
                    item.Name = s.ServerID;
                    item.Click += new EventHandler(item_Click);
                    tsbtnExeOn.DropDownItems.Add(item);
                }
            }
            ToolStripSeparator tsSeparator = new ToolStripSeparator();
            tsbtnExeOn.DropDownItems.Add(tsSeparator);

            ToolStripItem itemall = new ToolStripMenuItem();
            itemall.Text = "All Environments";
            itemall.Name = "all";
            itemall.Click += new EventHandler(item_Click);
            tsbtnExeOn.DropDownItems.Add(itemall);
        }

        void item_Click(object sender, EventArgs e)
        {
            try
            {
                ToolStripMenuItem item = sender as ToolStripMenuItem;
                if (item.Name == "all")
                {
                    foreach (var env in _envlist)
                    {
                        ExecuteQueryOnServer(env, _script);
                    }
                }
                else
                {
                    var server = _envlist.Where(x => x.ServerName == item.Name).FirstOrDefault();
                    if(server != null)
                        ExecuteQueryOnServer(server, _script);
                }
                MessageBox.Show("Query executed successfully", "Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void ExecuteQueryOnServer(ServerModel server,string query)
        {
            spdata = new StoredProcedureData();
            spdata.ExecuteQuery(server == null ? AppTimeConfiguration.MainServer : server,query);
        }

        private void tsbtnExe_Click(object sender, EventArgs e)
        {
            try
            {
                ExecuteQueryOnServer(AppTimeConfiguration.MainServer, _script);
                MessageBox.Show("Query executed successfully", "Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
