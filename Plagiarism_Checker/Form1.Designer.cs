namespace Plagiarism_Checker
{
    partial class Form1
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
            this.output_rtb = new System.Windows.Forms.RichTextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.output2_rtb = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // output_rtb
            // 
            this.output_rtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_rtb.Location = new System.Drawing.Point(1, 56);
            this.output_rtb.Name = "output_rtb";
            this.output_rtb.Size = new System.Drawing.Size(544, 461);
            this.output_rtb.TabIndex = 0;
            this.output_rtb.Text = "";
            // 
            // output2_rtb
            // 
            this.output2_rtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output2_rtb.Location = new System.Drawing.Point(576, 56);
            this.output2_rtb.Name = "output2_rtb";
            this.output2_rtb.Size = new System.Drawing.Size(544, 461);
            this.output2_rtb.TabIndex = 1;
            this.output2_rtb.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 541);
            this.Controls.Add(this.output2_rtb);
            this.Controls.Add(this.output_rtb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox output_rtb;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.RichTextBox output2_rtb;
    }
}

