using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plagiarism_Checker
{
    public class Word
    {
        public string word;
        public int count;


        public Word(string str,int c)
        {
            word = str;
            count = c;
        }

        public Word(string str)
        {
            word = str;
            count = 1;
        }

        public void increment()
        {
            count++;
        }


    }
}
