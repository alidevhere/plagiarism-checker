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
      //  file[] targetFiles;
      //  List<string> CommonWords;
        Color selectionColor;
        Report rpt;


        public Result(Report rpt,string text1,string text2)
        {
            InitializeComponent();

            this.rpt = rpt;
            //this.targetFiles = targetFiles;
            //this.CommonWords = CommonWords;
            selectionColor = Color.Yellow;
            file1.Text = rpt.file1;
            file2.Text = rpt.file2;
            A_rtb.Text = text1;
            B_rtb.Text = text2;
            colorText(A_rtb,rpt.CommonWords);
            colorText(B_rtb, rpt.CommonWords);

        }


        private void colorText(RichTextBox rt, List<Tuple<string,int,int>> list)
        {
            // Console.WriteLine(list[0]+" len ="+list[0].Length);
            for (int i = 0; i < list.Count; i++)
            {
                int start = 0;
                int H_index = 0;
                while (start < rt.TextLength)
                {
                    // Console.WriteLine("starting search at =" + start);
                    H_index = rt.Find(list[i].Item1, start, RichTextBoxFinds.WholeWord);
                    //  Console.WriteLine("found " + list[i] + " at index " + H_index);

                    if (H_index != -1)
                    {
                        rt.SelectionStart = H_index;
                        rt.SelectionLength = list[i].Item1.Length;
                        rt.SelectionBackColor = selectionColor;
                    }
                    else
                    {
                        //   Console.WriteLine("breaking loop..");
                        break;
                    }
                    start = H_index + list[i].Item1.Length;

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

        private void Result_Load(object sender, EventArgs e)
        {

        }
    }
}
