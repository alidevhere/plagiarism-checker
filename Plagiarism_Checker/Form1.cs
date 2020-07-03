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
            file f = new file(@"C:\Users\Ali\Desktop\test.txt");

            file f2 = new file(@"C:\Users\Ali\Desktop\test2.txt");
            //  Console.Clear();
            int cw=0;
            foreach (string key in f.Htable.Keys)
            {
                if (f2.Htable.ContainsKey(key))
                {
                    cw++;
                    Console.WriteLine(String.Format("Common word = {0},key={1}",f.Htable[key],key));
                }
                
            }

            Console.WriteLine("total words common= "+cw);



        }






    }
}
