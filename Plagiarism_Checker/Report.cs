using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plagiarism_Checker
{
    public class Report
    {
        public string file1;
        public string file2;
        public List<Tuple<string,int,int>> CommonWords;
        public Report(string f1, string f2)
        {
            file1 = f1;
            file2 = f2;
            CommonWords = new List<Tuple<string, int, int>>();// word ,count in file1,count in file2
        }
    }
}
