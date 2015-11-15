namespace SQLAdmin
{
    partial class frmHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sblblServer = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolstripMain = new System.Windows.Forms.ToolStrip();
            this.tsbtnConnect = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tslblDatabase = new System.Windows.Forms.ToolStripLabel();
            this.tscmbDatabase = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsSP = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testEnvironmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnSQLFolder = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1.SuspendLayout();
            this.toolstripMain.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.sblblServer});
            this.statusStrip1.Location = new System.Drawing.Point(0, 414);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(745, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(76, 17);
            this.toolStripStatusLabel1.Text = "Server Host : ";
            // 
            // sblblServer
            // 
            this.sblblServer.Name = "sblblServer";
            this.sblblServer.Size = new System.Drawing.Size(0, 17);
            // 
            // toolstripMain
            // 
            this.toolstripMain.AutoSize = false;
            this.toolstripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolstripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnConnect,
            this.toolStripSeparator1,
            this.tslblDatabase,
            this.tscmbDatabase,
            this.toolStripSeparator2,
            this.tsSP,
            this.toolStripSeparator3,
            this.tsbtnSQLFolder});
            this.toolstripMain.Location = new System.Drawing.Point(0, 24);
            this.toolstripMain.Name = "toolstripMain";
            this.toolstripMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolstripMain.Size = new System.Drawing.Size(745, 30);
            this.toolstripMain.TabIndex = 1;
            // 
            // tsbtnConnect
            // 
            this.tsbtnConnect.AutoSize = false;
            this.tsbtnConnect.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnConnect.Image")));
            this.tsbtnConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnConnect.Name = "tsbtnConnect";
            this.tsbtnConnect.Size = new System.Drawing.Size(72, 27);
            this.tsbtnConnect.Text = "Connect";
            this.tsbtnConnect.Click += new System.EventHandler(this.tsbtnConnect_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 30);
            // 
            // tslblDatabase
            // 
            this.tslblDatabase.Name = "tslblDatabase";
            this.tslblDatabase.Size = new System.Drawing.Size(55, 27);
            this.tslblDatabase.Text = "Database";
            // 
            // tscmbDatabase
            // 
            this.tscmbDatabase.BackColor = System.Drawing.SystemColors.Window;
            this.tscmbDatabase.Enabled = false;
            this.tscmbDatabase.Name = "tscmbDatabase";
            this.tscmbDatabase.Size = new System.Drawing.Size(150, 30);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 30);
            // 
            // tsSP
            // 
            this.tsSP.Image = ((System.Drawing.Image)(resources.GetObject("tsSP.Image")));
            this.tsSP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSP.Name = "tsSP";
            this.tsSP.Size = new System.Drawing.Size(123, 27);
            this.tsSP.Text = "Stored Procedures";
            this.tsSP.Click += new System.EventHandler(this.tsSP_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(745, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testEnvironmentsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // testEnvironmentsToolStripMenuItem
            // 
            this.testEnvironmentsToolStripMenuItem.Name = "testEnvironmentsToolStripMenuItem";
            this.testEnvironmentsToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.testEnvironmentsToolStripMenuItem.Text = "Test Environments";
            this.testEnvironmentsToolStripMenuItem.Click += new System.EventHandler(this.testEnvironmentsToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 30);
            // 
            // tsbtnSQLFolder
            // 
            this.tsbtnSQLFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnSQLFolder.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSQLFolder.Image")));
            this.tsbtnSQLFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSQLFolder.Name = "tsbtnSQLFolder";
            this.tsbtnSQLFolder.Size = new System.Drawing.Size(23, 27);
            this.tsbtnSQLFolder.Text = "toolStripButton1";
            this.tsbtnSQLFolder.Click += new System.EventHandler(this.tsbtnSQLFolder_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 436);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolstripMain);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmHome";
            this.Text = "SQL Admin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolstripMain.ResumeLayout(false);
            this.toolstripMain.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolstripMain;
        private System.Windows.Forms.ToolStripButton tsbtnConnect;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripLabel tslblDatabase;
        private System.Windows.Forms.ToolStripComboBox tscmbDatabase;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel sblblServer;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testEnvironmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsSP;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbtnSQLFolder;
    }
}

