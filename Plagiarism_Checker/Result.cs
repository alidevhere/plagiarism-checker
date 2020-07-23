using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plagiarism_Checker
{
    public partial class Result : Form
    {
        file[] targetFiles;
        List<string> CommonWords;
        Color selectionColor;



        public Result(file[] targetFiles, List<string> CommonWords)
        {
            InitializeComponent();

            this.targetFiles = targetFiles;
            this.CommonWords = CommonWords;
            selectionColor = Color.Yellow;

            ComnCount_lbl.Text = CommonWords.Count.ToString();

            for (int i= 0;i < targetFiles.Length;i++)
            {
                fileA_dd.Items.Add(targetFiles[i].fileName);
                fileB_dd.Items.Add(targetFiles[i].fileName);
            }


        }


        public Result()
        {
            InitializeComponent();
        }

        private void fileA_dd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(fileB_dd.SelectedIndex== fileA_dd.SelectedIndex)
            fileB_dd.SelectedIndex = (fileA_dd.SelectedIndex + 1)% fileB_dd.Items.Count;

            A_rtb.Text = "";
            A_rtb.Text= targetFiles[fileA_dd.SelectedIndex].unchangedFile;
            colorText(A_rtb, CommonWords);
            Awords_lbl.Text = targetFiles[fileA_dd.SelectedIndex].totalWords + "";
        }

        private void fileB_dd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fileB_dd.SelectedIndex == fileA_dd.SelectedIndex)
                fileA_dd.SelectedIndex = (fileB_dd.SelectedIndex + 1) % fileA_dd.Items.Count;
            B_rtb.Text = "";
            B_rtb.Text = targetFiles[fileB_dd.SelectedIndex].unchangedFile;
            colorText(B_rtb, CommonWords);
            Bwords_lbl.Text= targetFiles[fileB_dd.SelectedIndex].totalWords+"";
        }








        private void colorText(RichTextBox rt, List<string> list)
        {
            // Console.WriteLine(list[0]+" len ="+list[0].Length);
            for (int i = 0; i < list.Count; i++)
            {
                int start = 0;
                int H_index = 0;
                while (start < rt.TextLength)
                {
                    // Console.WriteLine("starting search at =" + start);
                    H_index = rt.Find(list[i], start, RichTextBoxFinds.WholeWord);
                    //  Console.WriteLine("found " + list[i] + " at index " + H_index);

                    if (H_index != -1)
                    {
                        rt.SelectionStart = H_index;
                        rt.SelectionLength = list[i].Length;
                        rt.SelectionBackColor = selectionColor;
                    }
                    else
                    {
                        //   Console.WriteLine("breaking loop..");
                        break;
                    }
                    start = H_index + list[i].Length;

                    //   Console.WriteLine("next start ="+start);

                }

            }
        }

       

        private void chooseSelectionColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            color.ShowDialog();
            // MessageBox.Show(color.Color.Name+"");
            selectionColor = color.Color;
        }
    }
}
