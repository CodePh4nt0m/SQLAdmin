using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using SQLAdmin.Model;

namespace SQLAdmin
{
    public partial class frmTestEnvironment : frmBase
    {

        public frmTestEnvironment()
        {
            InitializeComponent();
        }

        private void btnAddEnv_Click(object sender, EventArgs e)
        {
            frmAddServer frm = new frmAddServer(this);
            frm.ShowDialog();
        }

        private void frmTestEnvironment_Load(object sender, EventArgs e)
        {
            LoadSavedEnvironments();
            dgvEnv.ClearSelection();
            this.ActiveControl = btnAddEnv;
        }

        public void LoadSavedEnvironments()
        {
            try
            {
                List<TestEnvModel> envlist = new List<TestEnvModel>();
                XmlDataDocument xmldoc = new XmlDataDocument();
                XmlNodeList xmlnode;
                using (FileStream fs = new FileStream(XmlDB.Environments, FileMode.Open, FileAccess.Read))
                {
                    xmldoc.Load(fs);
                    xmlnode = xmldoc.GetElementsByTagName("env");
                    for (int i = 0; i <= xmlnode.Count - 1; i++)
                    {
                        envlist.Add(new TestEnvModel()
                        {
                            bSelected = true,
                            ServerID = xmlnode[i].Attributes["id"].Value,
                            ServerName = xmlnode[i].ChildNodes.Item(0).InnerText.Trim(),
                            Database = xmlnode[i].ChildNodes.Item(1).InnerText.Trim()
                        });
                    }
                    dgvEnv.AutoGenerateColumns = false;
                    dgvEnv.DataSource = envlist;
                    dgvEnv.Columns[0].DataPropertyName = "ServerID";
                    dgvEnv.Columns[1].DataPropertyName = "Database";
                    dgvEnv.Columns[2].DataPropertyName = "ServerName";
                    dgvEnv.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteNode()
        {
            if (dgvEnv.SelectedRows.Count < 1)
            {
                MessageBox.Show("Please select a Server");
                return;
            }
            string id = dgvEnv.SelectedRows[0].Cells[0].Value.ToString();
            var doc = new XmlDocument();
            doc.Load(XmlDB.Environments);
            var nodes = doc.GetElementsByTagName("env");
            var resultNodes = new List<XmlNode>();
            foreach (XmlNode node in nodes)
            {
                if (node.Attributes != null && node.Attributes["id"] != null && node.Attributes["id"].Value == id)
                    resultNodes.Add(node);
            }
            foreach (var node in resultNodes)
            {
                node.ParentNode.RemoveChild(node);
            }
            doc.Save(XmlDB.Environments);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DeleteNode();
            LoadSavedEnvironments();
        }

        private void frmTestEnvironment_Click(object sender, EventArgs e)
        {
            dgvEnv.ClearSelection();
        }
    }
}
