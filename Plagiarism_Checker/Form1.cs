﻿using System;
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
            //selectFile_dlg.ShowDialog();
            //MessageBox.Show(selectFile_dlg.);
            Hashtable[] hashtables = new Hashtable[2];

            
           // file f1 = new file(@"C:\Users\Ali\Desktop\test1.txt");

           //file f2 = new file(@"C:\Users\Ali\Desktop\test2.txt");
           //
           file f3 = new file(@"C:\Users\Ali\Desktop\test3.txt");

           file f4 = new file(@"C:\Users\Ali\Desktop\test4.txt");
            hashtables[0]= f3.Htable;
            hashtables[1] = f4.Htable;
          //  hashtables[2] = f3.Htable;
          //  hashtables[3] = f4.Htable;
            

            /*

            Console.WriteLine("hastabel 2 words");
            foreach (string key in f1.Htable.Values)
            {
                 Console.WriteLine(key);
            }

           */

            //calculate which file has minimun words :test case file 4 has 

            List<string> commonWords = new List<string>();//f4.Htable.Values.Cast<string>().ToList();

            foreach(DictionaryEntry word in hashtables[0])//currently 4th hashtable is minimum
            {
                bool found = false;
                for(int i=0;i<hashtables.Length;i++)
                {
                    if(hashtables[i].ContainsValue(word.Value))
                    {
                        found = true;
                    }
                    else
                    {
                        found = false;
                        break;
                    }
                }

                if(found)
                {
                    commonWords.Add(word.Value.ToString());
                }

            }

            //Console.WriteLine("Common words are "+commonWords.Count);

            /*
            foreach (string s in commonWords )
            {
                Console.WriteLine(s);
            }

            */



            //output_rtb.Text = 
            //"total words common= " + cw+"\r\n";

            output2_rtb.Text = f3.unchangedFile;
             output_rtb.Text=f4.unchangedFile;
             colorText(output_rtb,commonWords);

            colorText(output2_rtb, commonWords);
        }


        private void colorText(RichTextBox rt, List<string> list)
        {
           // Console.WriteLine(list[0]+" len ="+list[0].Length);
            for (int i = 0; i < list.Count; i++)
            {
                int start = 0;
                int H_index = 0;
                while (start<rt.TextLength)
                {

                   // Console.WriteLine("starting search at =" + start);
                    H_index = rt.Find(list[i], start, RichTextBoxFinds.WholeWord);
                  //  Console.WriteLine("found " + list[i] + " at index " + H_index);

                    if (H_index != -1)
                    {
                        rt.SelectionStart = H_index;
                        rt.SelectionLength = list[i].Length;
                        rt.SelectionBackColor = Color.Yellow;
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
        

    }
}
