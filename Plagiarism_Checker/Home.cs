using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plagiarism_Checker
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void chooseFolder_btn_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {

                 //   string[] files = Directory.(fbd.SelectedPath, "*.txt");
                      foreach (string file in Directory.EnumerateFiles(fbd.SelectedPath, "*.txt"))
                      {

                        FileInfo fi = new FileInfo(file);
                        
                        //MessageBox.Show(file+" "+ fi.Length);

                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(filesInfo_GV);
                        row.Cells[0].Value = fi.Name;
                        row.Cells[1].Value = fi.Length;
                        row.Cells[2].Value = fi.LastWriteTime;

                        filesInfo_GV.Rows.Add(row);




                      }

                    // System.Windows.Forms.MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
                }
            }
        }
    }
}
