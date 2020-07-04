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

            //selectFile_dlg.ShowDialog();
            //MessageBox.Show(selectFile_dlg.);
            Hashtable[] hashtables = new Hashtable[4];

            
            file f1 = new file(@"C:\Users\Ali\Desktop\test1.txt");

            file f2 = new file(@"C:\Users\Ali\Desktop\test2.txt");

            file f3 = new file(@"C:\Users\Ali\Desktop\test3.txt");

            file f4 = new file(@"C:\Users\Ali\Desktop\test4.txt");
            hashtables[0]= f1.Htable;
            hashtables[1] = f2.Htable;
            hashtables[2] = f3.Htable;
            hashtables[3] = f4.Htable;


            /*

            Console.WriteLine("hastabel 2 words");
            foreach (string key in f1.Htable.Values)
            {
                 Console.WriteLine(key);
            }

           */

                //calculate which file has minimun words :test case file 4 has 

                List<string> commonWords =f4.Htable.Values.Cast<string>().ToList();

            for (int i=0;i<hashtables.Length;i++)
            {
                if(i==3)//min hash index from which common words list is taken
                {
                    continue;
                }

                List<string> removed = new List<string>();
                // for(int j=0;j<commonWords.Count;j++)
                foreach(string s in commonWords)
                {
                    if(!hashtables[i].ContainsValue(s))
                    {
                        Console.WriteLine("Element removed= "+s+" uncommon with hash table "+i);
                        //
                        removed.Add(s);
                    }
                }

                foreach (string s in removed)
                {
                    commonWords.Remove(s);
                }

                

            }

//            Console.WriteLine("1 " + hashtables[0].ContainsValue("Machine"));
//            Console.WriteLine("2 " + hashtables[1].ContainsValue("Machine"));
//            Console.WriteLine("3 " + hashtables[2].ContainsValue("Machine"));
//            Console.WriteLine("4 " + hashtables[3].ContainsValue("Machine"));
            Console.WriteLine("Common words are "+commonWords.Count);

            foreach (string s in commonWords )
            {
                Console.WriteLine(s);
            }





            /*
             * 
            //  Console.Clear();
            int cw =0;
            foreach (string key in f.Htable.Keys)
            {
                if (f2.Htable.ContainsKey(key))
                {
                    cw++;
                    commonWords.Add((string)f.Htable[key]);
                  //  Console.WriteLine(String.Format("Common word = {0},key={1}",f.Htable[key],key));
                }
                
            }
            //Console.WriteLine("total words common= "+cw);
            output_rtb.Text = "total words common= " + cw+"\r\n";
            output_rtb.AppendText(f.unchangedFile);
            */
            //colorText(commonWords);
        }


        private void colorText(List<string> list)
        {/*
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


            */




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
