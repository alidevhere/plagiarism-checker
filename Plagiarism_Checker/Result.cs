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


        public Result(file[] targetFiles, List<string> CommonWords)
        {
            InitializeComponent();

            ComnCount_lbl.Text = CommonWords.Count.ToString();
        }


        public Result()
        {
            InitializeComponent();
        }
        
    }
}
