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
        private string fileType;
        private List<string> filePaths;

        public Home()
        {
            InitializeComponent();
            filePaths = new List<string>();
        }

        private void chooseFolder_btn_Click(object sender, EventArgs e)
        {
            if (txt_rb.Checked)
            {
                fileType = "*.txt";
            }
            else if (cpp_rb.Checked)
            {
                fileType = "*.cpp";
            }

            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    filesInfo_GV.Rows.Clear();
                    filePaths.Clear();
                    int count = 0;

                    foreach (string file in Directory.EnumerateFiles(fbd.SelectedPath, fileType))//"*.txt"
                    {

                        FileInfo fi = new FileInfo(file);
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(filesInfo_GV);
                        row.Cells[0].Value = fi.Name;
                        row.Cells[1].Value = fi.Length;
                        row.Cells[2].Value = fi.LastWriteTime;

                        filesInfo_GV.Rows.Add(row);
                        filePaths.Add(fi.FullName);
                        count++;

                    }
                    no_file_lbl.Text = count + "";
                    folder_txt.Text = fbd.SelectedPath;
                    if (count == 0)
                    {
                        MessageBox.Show("Folder does not contains specified files !!", "ERROR : 404 NOT FOUND ");
                        folder_txt.Text = "";
                    }
                    else if (count == 1)
                    {
                        MessageBox.Show("Please select more than one file to proceed", "ERROR : PROCESS ABORTED ");
                        folder_txt.Text = "";
                        filesInfo_GV.Rows.Clear();
                        filePaths.Clear();
                        no_file_lbl.Text = "";
                    }

                }
            }
        }

        private void check_btn_Click(object sender, EventArgs e)
        {
            try
            {
                FileInfo fi = new FileInfo(filePaths[0]);
                Report r;
                if (fi.Extension == ".cpp")
                {
                    string[] f = File.ReadAllLines(filePaths[0]);

                    for (int i = 0; i < f.Length; i++)
                    {
                        string s = f[i];
                        // Console.WriteLine(s);
                        if (s.StartsWith("#"))
                        {
                            f[i] = "<DIRECTIVE>";
                        }

                    }


                    for (int i = 0; i < f.Length; i++)
                    {
                        Console.WriteLine(f[i]);
                    }



                }
                else if (fi.Extension == ".txt")// && no_file_lbl.Text.Trim().Equals("2"))
                {

                    if (no_file_lbl.Text.Trim().Equals("2"))//smaller than two are handled earlier
                    {
                        file[] targetFiles = new file[filePaths.Count];
                        int i = 0;
                        foreach (string path in filePaths)
                        {
                            targetFiles[i] = new file(path);//building hash table
                            i++;
                        }

                        r= targetFiles[0].Compare(targetFiles[1].Htable,targetFiles[1].fileName);

                        Console.WriteLine("File name= "+r.file1+" "+r.file2 );
                        Console.WriteLine("Common Words: ");

                        this.Hide();
                        new Result(r,targetFiles[0].unchangedFile, targetFiles[1].unchangedFile).ShowDialog();


                      //  foreach (Tuple<string, int, int> item in r.CommonWords)
                      //  {
                      //      Console.WriteLine("Word in file 1 "+item.Item1+"  "+item.Item2 +"  "+item.Item3);
                      //  }
                        

                    }//greater than 2
                    else
                    {
                        this.Hide();
                        new MultipleFiles(filePaths).ShowDialog();
                    }
                }

            }
            catch
            {
                Console.WriteLine("EXCEPTION : PARAMETERS FAILED");
            }






        }
    }
}