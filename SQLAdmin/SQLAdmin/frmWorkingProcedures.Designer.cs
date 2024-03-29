﻿namespace SQLAdmin
{
    partial class frmWorkingProcedures
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSaveIndividual = new System.Windows.Forms.Button();
            this.btnGenVS = new System.Windows.Forms.Button();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.btnRemoveSelected = new System.Windows.Forms.Button();
            this.dgvSP = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAddSP = new System.Windows.Forms.Button();
            this.txtspname = new System.Windows.Forms.TextBox();
            this.cbAll = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSP)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSaveIndividual
            // 
            this.btnSaveIndividual.Location = new System.Drawing.Point(152, 351);
            this.btnSaveIndividual.Name = "btnSaveIndividual";
            this.btnSaveIndividual.Size = new System.Drawing.Size(101, 23);
            this.btnSaveIndividual.TabIndex = 7;
            this.btnSaveIndividual.Text = "Save Individual";
            this.btnSaveIndividual.UseVisualStyleBackColor = true;
            this.btnSaveIndividual.Click += new System.EventHandler(this.btnSaveIndividual_Click);
            // 
            // btnGenVS
            // 
            this.btnGenVS.Location = new System.Drawing.Point(55, 351);
            this.btnGenVS.Name = "btnGenVS";
            this.btnGenVS.Size = new System.Drawing.Size(91, 23);
            this.btnGenVS.TabIndex = 6;
            this.btnGenVS.Text = "Version Script";
            this.btnGenVS.UseVisualStyleBackColor = true;
            this.btnGenVS.Click += new System.EventHandler(this.btnGenVS_Click);
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Location = new System.Drawing.Point(498, 351);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(110, 23);
            this.btnRemoveAll.TabIndex = 5;
            this.btnRemoveAll.Text = "Remove All";
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // btnRemoveSelected
            // 
            this.btnRemoveSelected.Location = new System.Drawing.Point(401, 351);
            this.btnRemoveSelected.Name = "btnRemoveSelected";
            this.btnRemoveSelected.Size = new System.Drawing.Size(91, 23);
            this.btnRemoveSelected.TabIndex = 4;
            this.btnRemoveSelected.Text = "Remove";
            this.btnRemoveSelected.UseVisualStyleBackColor = true;
            this.btnRemoveSelected.Click += new System.EventHandler(this.btnRemoveSelected_Click);
            // 
            // dgvSP
            // 
            this.dgvSP.AllowUserToAddRows = false;
            this.dgvSP.AllowUserToDeleteRows = false;
            this.dgvSP.AllowUserToOrderColumns = true;
            this.dgvSP.AllowUserToResizeColumns = false;
            this.dgvSP.AllowUserToResizeRows = false;
            this.dgvSP.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvSP.ColumnHeadersHeight = 28;
            this.dgvSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSP.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvSP.Location = new System.Drawing.Point(8, 37);
            this.dgvSP.Name = "dgvSP";
            this.dgvSP.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSP.RowHeadersVisible = false;
            this.dgvSP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvSP.Size = new System.Drawing.Size(600, 308);
            this.dgvSP.TabIndex = 3;
            this.dgvSP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSP_CellContentClick);
            // 
            // Column3
            // 
            this.Column3.HeaderText = "";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.Width = 40;
            // 
            // Column2
            // 
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle11;
            this.Column2.HeaderText = "Stored Procedure";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 340;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "";
            this.Column4.Name = "Column4";
            this.Column4.Text = "View";
            this.Column4.UseColumnTextForButtonValue = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "";
            this.Column5.Name = "Column5";
            this.Column5.Text = "Generate Script";
            this.Column5.UseColumnTextForButtonValue = true;
            // 
            // btnAddSP
            // 
            this.btnAddSP.Location = new System.Drawing.Point(353, 5);
            this.btnAddSP.Name = "btnAddSP";
            this.btnAddSP.Size = new System.Drawing.Size(59, 23);
            this.btnAddSP.TabIndex = 2;
            this.btnAddSP.Text = "Add";
            this.btnAddSP.UseVisualStyleBackColor = true;
            this.btnAddSP.Click += new System.EventHandler(this.btnAddSP_Click);
            // 
            // txtspname
            // 
            this.txtspname.Location = new System.Drawing.Point(8, 7);
            this.txtspname.Name = "txtspname";
            this.txtspname.Size = new System.Drawing.Size(338, 20);
            this.txtspname.TabIndex = 1;
            // 
            // cbAll
            // 
            this.cbAll.AutoSize = true;
            this.cbAll.Checked = true;
            this.cbAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAll.Location = new System.Drawing.Point(22, 45);
            this.cbAll.Name = "cbAll";
            this.cbAll.Size = new System.Drawing.Size(15, 14);
            this.cbAll.TabIndex = 8;
            this.cbAll.UseVisualStyleBackColor = true;
            this.cbAll.CheckedChanged += new System.EventHandler(this.cbAll_CheckedChanged);
            // 
            // frmWorkingProcedures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 383);
            this.Controls.Add(this.cbAll);
            this.Controls.Add(this.btnSaveIndividual);
            this.Controls.Add(this.btnGenVS);
            this.Controls.Add(this.btnRemoveAll);
            this.Controls.Add(this.btnRemoveSelected);
            this.Controls.Add(this.dgvSP);
            this.Controls.Add(this.btnAddSP);
            this.Controls.Add(this.txtspname);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmWorkingProcedures";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Working Stored Procedures";
            this.Load += new System.EventHandler(this.frmWorkingProcedures_Load);
            this.Click += new System.EventHandler(this.frmWorkingProcedures_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtspname;
        private System.Windows.Forms.Button btnAddSP;
        private System.Windows.Forms.DataGridView dgvSP;
        private System.Windows.Forms.Button btnRemoveSelected;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.Button btnGenVS;
        private System.Windows.Forms.Button btnSaveIndividual;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn Column5;
        private System.Windows.Forms.CheckBox cbAll;
    }
}