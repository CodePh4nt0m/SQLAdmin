using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using SQLAdmin.Common;
using SQLAdmin.Data;
using SQLAdmin.Model;

namespace SQLAdmin
{
    public partial class frmAddServer : Form
    {
        private frmTestEnvironment _frmTestEnvironment;
        private ConnectServerData serverData;
        public frmAddServer(frmTestEnvironment frm)
        {
            InitializeComponent();
            _frmTestEnvironment = frm;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            AddTestEnvironment();
            _frmTestEnvironment.LoadSavedEnvironments();         
            this.Close();
        }

        private void AddTestEnvironment()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(XmlDB.Environments);


            XmlElement nodeenv = doc.CreateElement("env");
            nodeenv.SetAttribute("id", AppHelper.GenerateTimeId());

            XmlElement servernode = doc.CreateElement("server");
            servernode.InnerText = cmbServer.Text;

            XmlElement dbnode = doc.CreateElement("database");
            dbnode.InnerText = cmbDatabase.Text;

            XmlElement usernode = doc.CreateElement("user");
            usernode.InnerText = txtUsername.Text;

            XmlElement pwdnode = doc.CreateElement("password");
            pwdnode.InnerText = txtPassword.Text;

            nodeenv.AppendChild(servernode);
            nodeenv.AppendChild(dbnode);
            nodeenv.AppendChild(usernode);
            nodeenv.AppendChild(pwdnode);

            doc.DocumentElement.AppendChild(nodeenv);
            doc.Save(XmlDB.Environments);
        }

        void LoadDatabases()
        {
            try
            {
                ServerModel serverModel = new ServerModel();
                serverModel.ServerName = cmbServer.Text;
                serverModel.Username = txtUsername.Text;
                serverModel.Password = txtPassword.Text;
                serverModel.Database = "master";

                cmbDatabase.Items.Clear();
                serverData = new ConnectServerData();
                var dblist = serverData.GetDatabaseList(serverModel);
                cmbDatabase.DataSource = dblist;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLoadDB_Click(object sender, EventArgs e)
        {
            LoadDatabases();
        }
    }
}
