using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plagiarism_Checker
{//line feed =13
 //carriage return =10
 //https://theasciicode.com.ar/ascii-printable-characters/capital-letter-a-uppercase-ascii-code-65.html

    public class file
    {
        private string[] completeFile;
        int WordCount;
        public int  totalWords;
        public Hashtable Htable;
        public string unchangedFile;

        public file(string fileName)
        {
            string str;
            unchangedFile = File.ReadAllText(fileName);
            
            str = unchangedFile.Replace("\r","").Replace("\n","").Replace("\r\n", " ");             //replacing new line charaters

            completeFile = str.Split(' ');             //splitting file into words
         
            totalWords = completeFile.Length;
            WordCount = 0;

            Console.WriteLine("total words= "+totalWords);
            Htable = new Hashtable();

            //filling hash table with words of file
            for (int i = 0; i < totalWords; i++)
            {
                try
                {

                    string word = getWord();
                    string key = hashFunction(word);
                    if (!Htable.ContainsKey(key)&&(word!=null && key!=null))
                    {
                        Htable.Add(key, word);
                        Console.WriteLine("word= " + word + " key= " + key);
                        nextWord();
                    }
                    else
                    {
                        Console.WriteLine("Duplicate key ignored ==>  " + getWord());
                        nextWord();

                    }


                }
                catch (Exception a)
                {
                    Console.WriteLine("REAL EXCEPTION MESSAGE= " + a.Message);
                    
                }
            }
        }

        public string hashFunction(string str)
        {
            if (str == "")
            {
                return "NULL_STRING";
            }
            string r = "";
            for (int i = 0; i < str.Length; i++)
            {
                r += ((int)str[i] - 33);
            }
            //// Console.WriteLine();
            return r;

        }

        public string getWord()
        {
            if (WordCount < totalWords)
            {  
                return completeFile[WordCount];
            }
            else
            {
                return "NULL_RETURNED";
            }

            
        }

        public void nextWord()
        {
            if (WordCount<totalWords)
            {
                WordCount++;
            }


        }



    }
}
