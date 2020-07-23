namespace Plagiarism_Checker
{
    partial class Result
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
            this.label1 = new System.Windows.Forms.Label();
            this.ComnCount_lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Awords_lbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Bwords_lbl = new System.Windows.Forms.Label();
            this.fileB_dd = new System.Windows.Forms.ComboBox();
            this.fileA_dd = new System.Windows.Forms.ComboBox();
            this.B_rtb = new System.Windows.Forms.RichTextBox();
            this.A_rtb = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseSelectionColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(450, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Common Words";
            // 
            // ComnCount_lbl
            // 
            this.ComnCount_lbl.AutoSize = true;
            this.ComnCount_lbl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ComnCount_lbl.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComnCount_lbl.Location = new System.Drawing.Point(582, 49);
            this.ComnCount_lbl.Name = "ComnCount_lbl";
            this.ComnCount_lbl.Size = new System.Drawing.Size(15, 17);
            this.ComnCount_lbl.TabIndex = 1;
            this.ComnCount_lbl.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(193, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Words";
            // 
            // Awords_lbl
            // 
            this.Awords_lbl.AutoSize = true;
            this.Awords_lbl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Awords_lbl.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Awords_lbl.Location = new System.Drawing.Point(302, 123);
            this.Awords_lbl.Name = "Awords_lbl";
            this.Awords_lbl.Size = new System.Drawing.Size(15, 17);
            this.Awords_lbl.TabIndex = 3;
            this.Awords_lbl.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(659, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total Words";
            // 
            // Bwords_lbl
            // 
            this.Bwords_lbl.AutoSize = true;
            this.Bwords_lbl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Bwords_lbl.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bwords_lbl.Location = new System.Drawing.Point(768, 110);
            this.Bwords_lbl.Name = "Bwords_lbl";
            this.Bwords_lbl.Size = new System.Drawing.Size(15, 17);
            this.Bwords_lbl.TabIndex = 5;
            this.Bwords_lbl.Text = "0";
            // 
            // fileB_dd
            // 
            this.fileB_dd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fileB_dd.FormattingEnabled = true;
            this.fileB_dd.Location = new System.Drawing.Point(662, 76);
            this.fileB_dd.Name = "fileB_dd";
            this.fileB_dd.Size = new System.Drawing.Size(170, 21);
            this.fileB_dd.TabIndex = 6;
            this.fileB_dd.SelectedIndexChanged += new System.EventHandler(this.fileB_dd_SelectedIndexChanged);
            // 
            // fileA_dd
            // 
            this.fileA_dd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fileA_dd.FormattingEnabled = true;
            this.fileA_dd.Location = new System.Drawing.Point(192, 78);
            this.fileA_dd.Name = "fileA_dd";
            this.fileA_dd.Size = new System.Drawing.Size(149, 21);
            this.fileA_dd.TabIndex = 7;
            this.fileA_dd.SelectedIndexChanged += new System.EventHandler(this.fileA_dd_SelectedIndexChanged);
            // 
            // B_rtb
            // 
            this.B_rtb.Location = new System.Drawing.Point(541, 148);
            this.B_rtb.Name = "B_rtb";
            this.B_rtb.ReadOnly = true;
            this.B_rtb.Size = new System.Drawing.Size(604, 389);
            this.B_rtb.TabIndex = 8;
            this.B_rtb.Text = "";
            // 
            // A_rtb
            // 
            this.A_rtb.Location = new System.Drawing.Point(-1, 148);
            this.A_rtb.Name = "A_rtb";
            this.A_rtb.ReadOnly = true;
            this.A_rtb.Size = new System.Drawing.Size(515, 389);
            this.A_rtb.TabIndex = 9;
            this.A_rtb.Text = "";
            this.A_rtb.ZoomFactor = 10F;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1173, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chooseSelectionColorToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // chooseSelectionColorToolStripMenuItem
            // 
            this.chooseSelectionColorToolStripMenuItem.Name = "chooseSelectionColorToolStripMenuItem";
            this.chooseSelectionColorToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.chooseSelectionColorToolStripMenuItem.Text = "Choose selection color";
            this.chooseSelectionColorToolStripMenuItem.Click += new System.EventHandler(this.chooseSelectionColorToolStripMenuItem_Click);
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1173, 549);
            this.Controls.Add(this.A_rtb);
            this.Controls.Add(this.B_rtb);
            this.Controls.Add(this.fileA_dd);
            this.Controls.Add(this.fileB_dd);
            this.Controls.Add(this.Bwords_lbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Awords_lbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ComnCount_lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Result";
            this.Text = "Result";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ComnCount_lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Awords_lbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Bwords_lbl;
        private System.Windows.Forms.ComboBox fileB_dd;
        private System.Windows.Forms.ComboBox fileA_dd;
        private System.Windows.Forms.RichTextBox B_rtb;
        private System.Windows.Forms.RichTextBox A_rtb;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chooseSelectionColorToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}