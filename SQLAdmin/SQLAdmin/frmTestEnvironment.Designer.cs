namespace SQLAdmin
{
    partial class frmTestEnvironment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTestEnvironment));
            this.dgvEnv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddEnv = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEnv
            // 
            this.dgvEnv.AllowUserToAddRows = false;
            this.dgvEnv.AllowUserToDeleteRows = false;
            this.dgvEnv.AllowUserToOrderColumns = true;
            this.dgvEnv.AllowUserToResizeColumns = false;
            this.dgvEnv.AllowUserToResizeRows = false;
            this.dgvEnv.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvEnv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column2});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEnv.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEnv.Location = new System.Drawing.Point(6, 5);
            this.dgvEnv.MultiSelect = false;
            this.dgvEnv.Name = "dgvEnv";
            this.dgvEnv.RowHeadersVisible = false;
            this.dgvEnv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEnv.Size = new System.Drawing.Size(354, 209);
            this.dgvEnv.TabIndex = 0;
            // 
            // Column1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Database";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Server";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 180;
            // 
            // btnAddEnv
            // 
            this.btnAddEnv.Location = new System.Drawing.Point(372, 12);
            this.btnAddEnv.Name = "btnAddEnv";
            this.btnAddEnv.Size = new System.Drawing.Size(75, 23);
            this.btnAddEnv.TabIndex = 1;
            this.btnAddEnv.Text = "New";
            this.btnAddEnv.UseVisualStyleBackColor = true;
            this.btnAddEnv.Click += new System.EventHandler(this.btnAddEnv_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(372, 156);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Location = new System.Drawing.Point(372, 185);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveAll.TabIndex = 3;
            this.btnRemoveAll.Text = "Remove All";
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            // 
            // frmTestEnvironment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 220);
            this.Controls.Add(this.btnRemoveAll);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAddEnv);
            this.Controls.Add(this.dgvEnv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTestEnvironment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Test Environments";
            this.Load += new System.EventHandler(this.frmTestEnvironment_Load);
            this.Click += new System.EventHandler(this.frmTestEnvironment_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddEnv;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.DataGridView dgvEnv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}