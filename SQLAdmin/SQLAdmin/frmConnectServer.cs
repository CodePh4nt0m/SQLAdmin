using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLAdmin.Common;
using SQLAdmin.Data;
using SQLAdmin.Model;

namespace SQLAdmin
{
    public partial class frmConnectServer : Form
    {
        private ConnectServerData serverData;
        private frmHome _parent;
        public frmConnectServer()
        {
            InitializeComponent();
        }

        public frmConnectServer(frmHome frm)
        {
            InitializeComponent();
            _parent = frm;
        }
        private void btnSetServer_Click(object sender, EventArgs e)
        {
            LoadDatabases();
        }

        private void btnLoginServer_Click(object sender, EventArgs e)
        {
            LoginToServer();           
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

                AppTimeConfiguration.MainServer = serverModel;

                cmbDatabase.Items.Clear();
                serverData = new ConnectServerData();
                var dblist = serverData.GetDatabaseList(null);
                cmbDatabase.DataSource = dblist;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmConnectServer_Load(object sender, EventArgs e)
        {
            LoadSavedLoginData();
            this.ActiveControl = label1;
        }

        private void LoadSavedLoginData()
        {
            try
            {
                ConfigurationHelper cHelper = new ConfigurationHelper();

                string server = cHelper.GetConfigurationValue("Server");
                string username = cHelper.GetConfigurationValue("Username");
                string password = cHelper.GetConfigurationValue("Password");

                cmbServer.Text = server;
                txtUsername.Text = username;
                txtPassword.Text = password;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SaveLoginData()
        {
            try
            {
                ConfigurationHelper cHelper = new ConfigurationHelper();
                string server = cmbServer.Text;
                string username = txtUsername.Text;
                string password = txtPassword.Text;

                cHelper.AddConfiguration("Server", server);
                cHelper.AddConfiguration("Username", username);
                cHelper.AddConfiguration("Password", password);

                AppTimeConfiguration.MainServer.ServerName = server;
                AppTimeConfiguration.MainServer.Username = username;
                AppTimeConfiguration.MainServer.Password = password;
                AppTimeConfiguration.MainServer.Database = cmbDatabase.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void LoginToServer()
        {
            try
            {
                if (cbRemember.Checked)
                    SaveLoginData();
                MessageBox.Show("Login Success");
                UpdateSystemDetails();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateSystemDetails()
        {
            _parent.SetStatusDetails();
        }
    }
}
