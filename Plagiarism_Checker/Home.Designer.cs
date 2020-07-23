namespace Plagiarism_Checker
{
    partial class Home
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.folder_txt = new System.Windows.Forms.TextBox();
            this.chooseFolder_btn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.no_file_lbl = new System.Windows.Forms.Label();
            this.filesInfo_GV = new System.Windows.Forms.DataGridView();
            this.txt_rb = new System.Windows.Forms.RadioButton();
            this.cpp_rb = new System.Windows.Forms.RadioButton();
            this.fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fsize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifiDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filesInfo_GV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(369, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plagiarism Checker";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1055, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "file";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(239, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "File Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(194, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Selected Folder";
            // 
            // folder_txt
            // 
            this.folder_txt.Location = new System.Drawing.Point(350, 177);
            this.folder_txt.Name = "folder_txt";
            this.folder_txt.Size = new System.Drawing.Size(258, 20);
            this.folder_txt.TabIndex = 7;
            // 
            // chooseFolder_btn
            // 
            this.chooseFolder_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseFolder_btn.Location = new System.Drawing.Point(651, 177);
            this.chooseFolder_btn.Name = "chooseFolder_btn";
            this.chooseFolder_btn.Size = new System.Drawing.Size(108, 23);
            this.chooseFolder_btn.TabIndex = 10;
            this.chooseFolder_btn.Text = "Choose Folder";
            this.chooseFolder_btn.UseVisualStyleBackColor = true;
            this.chooseFolder_btn.Click += new System.EventHandler(this.chooseFolder_btn_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(918, 454);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Check Plagiarism";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(166, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "No. of selected files";
            // 
            // no_file_lbl
            // 
            this.no_file_lbl.AutoSize = true;
            this.no_file_lbl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.no_file_lbl.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no_file_lbl.Location = new System.Drawing.Point(355, 231);
            this.no_file_lbl.Name = "no_file_lbl";
            this.no_file_lbl.Size = new System.Drawing.Size(17, 19);
            this.no_file_lbl.TabIndex = 14;
            this.no_file_lbl.Text = "0";
            // 
            // filesInfo_GV
            // 
            this.filesInfo_GV.AllowUserToAddRows = false;
            this.filesInfo_GV.AllowUserToDeleteRows = false;
            this.filesInfo_GV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.filesInfo_GV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fname,
            this.fsize,
            this.modifiDate});
            this.filesInfo_GV.Location = new System.Drawing.Point(150, 288);
            this.filesInfo_GV.Name = "filesInfo_GV";
            this.filesInfo_GV.ReadOnly = true;
            this.filesInfo_GV.Size = new System.Drawing.Size(644, 151);
            this.filesInfo_GV.TabIndex = 15;
            // 
            // txt_rb
            // 
            this.txt_rb.AutoSize = true;
            this.txt_rb.Checked = true;
            this.txt_rb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_rb.Location = new System.Drawing.Point(350, 136);
            this.txt_rb.Name = "txt_rb";
            this.txt_rb.Size = new System.Drawing.Size(111, 20);
            this.txt_rb.TabIndex = 16;
            this.txt_rb.TabStop = true;
            this.txt_rb.Text = "English Text";
            this.txt_rb.UseVisualStyleBackColor = true;
            // 
            // cpp_rb
            // 
            this.cpp_rb.AutoSize = true;
            this.cpp_rb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpp_rb.Location = new System.Drawing.Point(497, 136);
            this.cpp_rb.Name = "cpp_rb";
            this.cpp_rb.Size = new System.Drawing.Size(82, 20);
            this.cpp_rb.TabIndex = 17;
            this.cpp_rb.Text = "C++ File";
            this.cpp_rb.UseVisualStyleBackColor = true;
            // 
            // fname
            // 
            this.fname.HeaderText = "File Name";
            this.fname.Name = "fname";
            this.fname.ReadOnly = true;
            this.fname.Width = 200;
            // 
            // fsize
            // 
            this.fsize.HeaderText = "File Size";
            this.fsize.Name = "fsize";
            this.fsize.ReadOnly = true;
            this.fsize.Width = 200;
            // 
            // modifiDate
            // 
            this.modifiDate.HeaderText = "Last Modified";
            this.modifiDate.Name = "modifiDate";
            this.modifiDate.ReadOnly = true;
            this.modifiDate.Width = 200;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1055, 522);
            this.Controls.Add(this.cpp_rb);
            this.Controls.Add(this.txt_rb);
            this.Controls.Add(this.filesInfo_GV);
            this.Controls.Add(this.no_file_lbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.chooseFolder_btn);
            this.Controls.Add(this.folder_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filesInfo_GV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox folder_txt;
        private System.Windows.Forms.Button chooseFolder_btn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label no_file_lbl;
        private System.Windows.Forms.DataGridView filesInfo_GV;
        private System.Windows.Forms.RadioButton txt_rb;
        private System.Windows.Forms.RadioButton cpp_rb;
        private System.Windows.Forms.DataGridViewTextBoxColumn fname;
        private System.Windows.Forms.DataGridViewTextBoxColumn fsize;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifiDate;
    }
}