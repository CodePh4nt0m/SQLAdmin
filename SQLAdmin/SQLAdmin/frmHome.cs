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

namespace SQLAdmin
{
    public partial class frmHome : frmBase
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void tsbtnConnect_Click(object sender, EventArgs e)
        {
            frmConnectServer frm = new frmConnectServer(this);
            frm.ShowDialog();
        }

        public void SetStatusDetails()
        {
            sblblServer.Text = AppTimeConfiguration.MainServer.ServerName;
            tscmbDatabase.Items.Clear();
            tscmbDatabase.Items.Add(AppTimeConfiguration.MainServer.Database);
            tscmbDatabase.SelectedIndex = 0;
        }

        private void testEnvironmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTestEnvironment frm = new frmTestEnvironment();
            frm.MdiParent = this;
            frm.Show();
        }

        private void tsSP_Click(object sender, EventArgs e)
        {
            frmWorkingProcedures frm = new frmWorkingProcedures();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
