using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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
    public partial class frmWorkingProcedures : frmBase
    {
        private StoredProcedureData spdata;

        public frmWorkingProcedures()
        {
            InitializeComponent();
            dgvSP.AutoGenerateColumns = false;
        }

        private void btnAddSP_Click(object sender, EventArgs e)
        {
            if(txtspname.Text.Trim() != "")
                AddSpToList();
            LoadWorkingSPs();
        }

        private void AddSpToList()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(XmlDB.StoredProcedures);

            string spid = AppHelper.GenerateTimeId();
            XmlElement spnode = doc.CreateElement("sp");
            spnode.SetAttribute("id", spid);

            XmlElement namenode = doc.CreateElement("name");
            namenode.InnerText = txtspname.Text;

            spnode.AppendChild(namenode);

            doc.DocumentElement.AppendChild(spnode);
            doc.Save(XmlDB.StoredProcedures);

            dgvSP.Refresh();
            txtspname.Clear();
        }

        private void LoadWorkingSPs()
        {
            try
            {
                List<StoredProcedureModel> splist = new List<StoredProcedureModel>();
                XmlDataDocument xmldoc = new XmlDataDocument();
                XmlNodeList xmlnode;
                using (FileStream fs = new FileStream(XmlDB.StoredProcedures, FileMode.Open, FileAccess.Read))
                {
                    xmldoc.Load(fs);
                    xmlnode = xmldoc.GetElementsByTagName("sp");
                    for (int i = 0; i <= xmlnode.Count - 1; i++)
                    {
                        splist.Add(new StoredProcedureModel()
                        {
                            bSelected = true,
                            ID = xmlnode[i].Attributes["id"].Value,
                            Name = xmlnode[i].ChildNodes.Item(0).InnerText.Trim()
                        });
                    }

                    dgvSP.DataSource = splist;
                    dgvSP.Columns[0].DataPropertyName = "ID";
                    dgvSP.Columns[1].DataPropertyName = "bSelected";
                    dgvSP.Columns[2].DataPropertyName = "Name";
                    dgvSP.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmWorkingProcedures_Load(object sender, EventArgs e)
        {
            LoadWorkingSPs();
            dgvSP.ClearSelection();
            this.ActiveControl = btnAddSP;
        }

        private void btnRemoveSelected_Click(object sender, EventArgs e)
        {
            try
            {
                RemoveSelected();
                LoadWorkingSPs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            try
            {
                RemoveAll();
                LoadWorkingSPs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void RemoveSelected()
        {
            List<string> dellist = new List<string>();
            foreach (DataGridViewRow row in dgvSP.Rows)
            {
                if (Convert.ToBoolean(row.Cells[1].Value))
                    dellist.Add(row.Cells[0].Value.ToString());

            }

            var doc = new XmlDocument();
            doc.Load(XmlDB.StoredProcedures);
            var nodes = doc.GetElementsByTagName("sp");
            var resultNodes = new List<XmlNode>();
            foreach (var id in dellist)
            {
                foreach (XmlNode node in nodes)
                {
                    if (node.Attributes != null && node.Attributes["id"] != null && node.Attributes["id"].Value == id)
                        resultNodes.Add(node);
                }
            }

            foreach (var node in resultNodes)
            {
                node.ParentNode.RemoveChild(node);
            }
            doc.Save(XmlDB.StoredProcedures);
        }

        void RemoveAll()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(XmlDB.StoredProcedures);
            XmlNode root = doc.DocumentElement;
            //Remove all attribute and child nodes.
            root.RemoveAll();
            doc.Save(XmlDB.StoredProcedures);
        }

        private void frmWorkingProcedures_Click(object sender, EventArgs e)
        {
            dgvSP.ClearSelection();
        }
        private void OpenSelectedSP(int index)
        {
            string spname = dgvSP.Rows[index].Cells[2].Value.ToString();
            spdata = new StoredProcedureData();
            string spbody = spdata.GetScript(null, spname);
            frmSPViewer frm = new frmSPViewer(spbody);
            frm.Show();
        }

        private void dgvSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.ColumnIndex == 3)
                    OpenSelectedSP(e.RowIndex);
                else if (e.ColumnIndex == 4)
                    GenerateScript(e.RowIndex);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GenerateScript(int index)
        {
            string spname = dgvSP.Rows[index].Cells[2].Value.ToString();
            spdata = new StoredProcedureData();
            string spbody = spdata.GetScript(null, spname);
            frmSPViewer frm = new frmSPViewer(SPHelper.GenerateIndividualScript(spname,spbody));
            frm.Show();
        }

        private void btnGenVS_Click(object sender, EventArgs e)
        {
            try
            {
                GenerateVersionScript();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GenerateVersionScript()
        {
            SPHelper spHelper = new SPHelper();
            List<string> splist = new List<string>();
            foreach(DataGridViewRow rw in dgvSP.Rows)
            {
                if(Convert.ToBoolean(rw.Cells[1].Value))
                    splist.Add(rw.Cells[2].Value.ToString());
            }
            string version_script = spHelper.GenerateVersionScript(splist);
            FileHelper fileHelper = new FileHelper();
            fileHelper.SaveVersionScript(version_script);
            frmSPViewer frm = new frmSPViewer(version_script);
            frm.Show();
        }

        private void btnSaveIndividual_Click(object sender, EventArgs e)
        {
            try
            {
                SaveSelectedSPs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SaveSelectedSPs()
        {
            List<string> splist = new List<string>();
            FileHelper fileHelper = new FileHelper();
            foreach (DataGridViewRow rw in dgvSP.Rows)
            {
                if (Convert.ToBoolean(rw.Cells[1].Value))
                    splist.Add(rw.Cells[2].Value.ToString());
                spdata = new StoredProcedureData();
                foreach (var sp in splist)
                {
                    string query = spdata.GetScript(null, sp);
                    fileHelper.SaveStoredProcedure(query,sp);
                }
            }
            MessageBox.Show("Query executed successfully", "Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            string dirname = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString();
            string path = Application.StartupPath + "\\GeneratedScripts\\" + dirname + "\\StoredProcedures";
            Process.Start(path);
        }
    }
}
