using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plagiarism_Checker
{//tto save time add int not convert from string to int
    public class hash
    {//aascii 33--126

        //1j6
        //(49--106--54
        //167321

        public Hashtable ht;
        public hash()
        {
            ht = new Hashtable();
        }


       public string hashFunction(string str)
        {
            if(str=="")
            {
                return "NULL_STRING";
            }
            string r="";
            for (int i=0;i< str.Length;i++)
            {
                r += ((int)str[i] - 33);
                

            }
            //// Console.WriteLine();
            return r;

        }

        public void createHash(string fileName)
        {



        }


    }
}
