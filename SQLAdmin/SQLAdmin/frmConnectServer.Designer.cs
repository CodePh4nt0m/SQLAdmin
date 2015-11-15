namespace SQLAdmin
{
    partial class frmConnectServer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConnectServer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbRemember = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbDatabase = new System.Windows.Forms.ComboBox();
            this.btnLoginServer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnSetServer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbServer = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.cbRemember);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cmbDatabase);
            this.panel1.Controls.Add(this.btnLoginServer);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.btnSetServer);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbServer);
            this.panel1.Location = new System.Drawing.Point(4, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 189);
            this.panel1.TabIndex = 7;
            // 
            // cbRemember
            // 
            this.cbRemember.AutoSize = true;
            this.cbRemember.Checked = true;
            this.cbRemember.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRemember.Location = new System.Drawing.Point(91, 153);
            this.cbRemember.Name = "cbRemember";
            this.cbRemember.Size = new System.Drawing.Size(106, 17);
            this.cbRemember.TabIndex = 21;
            this.cbRemember.Text = "Remember Login";
            this.cbRemember.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Database:";
            // 
            // cmbDatabase
            // 
            this.cmbDatabase.FormattingEnabled = true;
            this.cmbDatabase.Location = new System.Drawing.Point(91, 110);
            this.cmbDatabase.Name = "cmbDatabase";
            this.cmbDatabase.Size = new System.Drawing.Size(233, 21);
            this.cmbDatabase.TabIndex = 4;
            // 
            // btnLoginServer
            // 
            this.btnLoginServer.Location = new System.Drawing.Point(237, 147);
            this.btnLoginServer.Name = "btnLoginServer";
            this.btnLoginServer.Size = new System.Drawing.Size(87, 23);
            this.btnLoginServer.TabIndex = 6;
            this.btnLoginServer.Text = "Login";
            this.btnLoginServer.UseVisualStyleBackColor = true;
            this.btnLoginServer.Click += new System.EventHandler(this.btnLoginServer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(150, 76);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(174, 20);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(150, 50);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(174, 20);
            this.txtUsername.TabIndex = 2;
            // 
            // btnSetServer
            // 
            this.btnSetServer.Location = new System.Drawing.Point(330, 108);
            this.btnSetServer.Name = "btnSetServer";
            this.btnSetServer.Size = new System.Drawing.Size(30, 23);
            this.btnSetServer.TabIndex = 5;
            this.btnSetServer.Text = ">";
            this.btnSetServer.UseVisualStyleBackColor = true;
            this.btnSetServer.Click += new System.EventHandler(this.btnSetServer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "User Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server :";
            // 
            // cmbServer
            // 
            this.cmbServer.FormattingEnabled = true;
            this.cmbServer.Location = new System.Drawing.Point(91, 23);
            this.cmbServer.Name = "cmbServer";
            this.cmbServer.Size = new System.Drawing.Size(233, 21);
            this.cmbServer.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(411, 74);
            this.panel2.TabIndex = 8;
            // 
            // frmConnectServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 272);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConnectServer";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connect Server";
            this.Load += new System.EventHandler(this.frmConnectServer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbRemember;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbDatabase;
        private System.Windows.Forms.Button btnLoginServer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnSetServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbServer;
        private System.Windows.Forms.Panel panel2;
    }
}