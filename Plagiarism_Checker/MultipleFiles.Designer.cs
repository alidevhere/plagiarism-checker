namespace Plagiarism_Checker
{
    partial class MultipleFiles
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
            this.mf_pnl = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // mf_pnl
            // 
            this.mf_pnl.Location = new System.Drawing.Point(12, 12);
            this.mf_pnl.Name = "mf_pnl";
            this.mf_pnl.Size = new System.Drawing.Size(1133, 574);
            this.mf_pnl.TabIndex = 0;
            // 
            // MultipleFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 598);
            this.Controls.Add(this.mf_pnl);
            this.Name = "MultipleFiles";
            this.Text = "MultipleFiles";
            this.Load += new System.EventHandler(this.MultipleFiles_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mf_pnl;
    }
}