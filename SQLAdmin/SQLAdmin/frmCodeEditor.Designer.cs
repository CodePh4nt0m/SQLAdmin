﻿namespace SQLAdmin
{
    partial class frmCodeEditor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCodeEditor));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnExe = new System.Windows.Forms.ToolStripButton();
            this.tsbtnExeOn = new System.Windows.Forms.ToolStripDropDownButton();
            this.txtSyntacBox = new FastColoredTextBoxNS.FastColoredTextBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSyntacBox)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnExe,
            this.tsbtnExeOn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(1019, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnExe
            // 
            this.tsbtnExe.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnExe.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnExe.Name = "tsbtnExe";
            this.tsbtnExe.Size = new System.Drawing.Size(51, 22);
            this.tsbtnExe.Text = "Execute";
            this.tsbtnExe.Click += new System.EventHandler(this.tsbtnExe_Click);
            // 
            // tsbtnExeOn
            // 
            this.tsbtnExeOn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnExeOn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnExeOn.Name = "tsbtnExeOn";
            this.tsbtnExeOn.Size = new System.Drawing.Size(79, 22);
            this.tsbtnExeOn.Text = "Execute On";
            // 
            // txtSyntacBox
            // 
            this.txtSyntacBox.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.txtSyntacBox.AutoIndentCharsPatterns = "";
            this.txtSyntacBox.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.txtSyntacBox.BackBrush = null;
            this.txtSyntacBox.CharHeight = 14;
            this.txtSyntacBox.CharWidth = 8;
            this.txtSyntacBox.CommentPrefix = "--";
            this.txtSyntacBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSyntacBox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtSyntacBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSyntacBox.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.txtSyntacBox.IsReplaceMode = false;
            this.txtSyntacBox.Language = FastColoredTextBoxNS.Language.SQL;
            this.txtSyntacBox.LeftBracket = '(';
            this.txtSyntacBox.Location = new System.Drawing.Point(0, 25);
            this.txtSyntacBox.Name = "txtSyntacBox";
            this.txtSyntacBox.Paddings = new System.Windows.Forms.Padding(0);
            this.txtSyntacBox.RightBracket = ')';
            this.txtSyntacBox.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txtSyntacBox.ServiceColors = null;
            this.txtSyntacBox.Size = new System.Drawing.Size(1019, 478);
            this.txtSyntacBox.TabIndex = 3;
            this.txtSyntacBox.Zoom = 100;
            // 
            // frmCodeEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 503);
            this.Controls.Add(this.txtSyntacBox);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCodeEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Script Editor";
            this.Load += new System.EventHandler(this.frmCodeEditor_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSyntacBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnExe;
        private System.Windows.Forms.ToolStripDropDownButton tsbtnExeOn;
        private FastColoredTextBoxNS.FastColoredTextBox txtSyntacBox;
    }
}