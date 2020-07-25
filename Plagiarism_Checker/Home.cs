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

                if(fi.Extension==".cpp")
                {



                    string[] f = File.ReadAllLines(filePaths[0]);


                    for(int i=0;i< f.Length;i++)
                    {
                        string s=f[i];
                       // Console.WriteLine(s);
                        if(s.StartsWith("#"))
                        {
                            f[i] = "<DIRECTIVE>";
                        }

                    }


                    for (int i = 0; i < f.Length; i++)
                    {
                        Console.WriteLine(f[i]);
                    }



                }
                else if(fi.Extension == ".txt")
                      {

                    file[] targetFiles = new file[filePaths.Count];
                    int minHashIndex = 0;
                    int i = 0;
                    foreach (string path in filePaths)
                    {
                        targetFiles[i] = new file(path);

                        //find minimum length hash table
                        if (targetFiles[i].Htable.Count <= targetFiles[minHashIndex].Htable.Count)
                        {
                            minHashIndex = i;
                        }
                        i++;

                        Console.WriteLine("Min hash index= " + minHashIndex + " Min hash count=" + targetFiles[minHashIndex].Htable.Count);
                        //Console.WriteLine("");

                    }

                    //Now create list of common words which consists of least length hash table

                    List<string> CommonWords = targetFiles[minHashIndex].Htable.Values.Cast<string>().ToList();//cast the hash table values into list

                    Console.WriteLine("Common words = " + CommonWords.Count);

                    for (int k = 0; k < targetFiles.Length; k++)
                    {
                        if (k != minHashIndex)
                        {
                            targetFiles[k].Compare(CommonWords);
                        }
                        Console.WriteLine("After checking " + k + " Common words = " + CommonWords.Count);
                    }

                    this.Hide();
                    new Result(targetFiles, CommonWords).ShowDialog();

                }

            }
            catch
            {
                Console.WriteLine("EXCEPTION : PARAMETERS FAILED");
            }






        }
    }
}