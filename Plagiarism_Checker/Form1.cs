using System;
using System.Collections;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {//93 93 93 93 93 93

            List<string> commonWords = new List<string>();
            file f = new file(@"C:\Users\Ali\Desktop\test.txt");

            file f2 = new file(@"C:\Users\Ali\Desktop\test2.txt");
            //  Console.Clear();
            int cw=0;
            foreach (string key in f.Htable.Keys)
            {
                if (f2.Htable.ContainsKey(key))
                {
                    cw++;
                    commonWords.Add((string)f.Htable[key]);
                    Console.WriteLine(String.Format("Common word = {0},key={1}",f.Htable[key],key));
                }
                
            }

            //Console.WriteLine("total words common= "+cw);
            output_rtb.Text = "total words common= " + cw+"\r\n";
            output_rtb.AppendText(f.unchangedFile);

            colorText(commonWords);
        }


        private void colorText(List<string> list)
        {
            int i = 0;
            int current=0;
            int prev=0;
            int index;
            while(i <list.Count)
            {
                index = output_rtb.Find(list[i], current, RichTextBoxFinds.WholeWord);
                if (selectIndex == -1)
                {

                    Console.WriteLine(list[i] + "  not found in text box");
                    break;
                }
                output_rtb.SelectionStart =index;
                output_rtb.SelectionLength = list[i].Length;
                output_rtb.SelectionBackColor = Color.Green;
                Console.WriteLine("index==" + selectIndex);
                index = current + list[i].Length;
            }







            /*
            int index = 0;
            int selectIndex=-1;
            for (int i = 0; i < list.Count; i++)
            {
               
                for (selectIndex = 0; selectIndex < output_rtb.TextLength; selectIndex++)
                {

                    selectIndex = output_rtb.Find(list[i], index, RichTextBoxFinds.WholeWord);
                    if (selectIndex == -1)
                    {
                        
                        Console.WriteLine(list[i] + "  not found in text box");
                        break;
                    }
                    output_rtb.SelectionStart = selectIndex;
                    output_rtb.SelectionLength = list[i].Length;
                    output_rtb.SelectionBackColor = Color.Green;
                    Console.WriteLine("index==" + selectIndex);
                    index = selectIndex + list[i].Length;
                }

            }
            */
        }



    }
}
