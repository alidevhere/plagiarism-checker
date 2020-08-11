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
        public string fileName;         // only contains file name without any path

        public file(string fileName)
        {
            this.fileName = Path.GetFileName(fileName);
            string str;
            unchangedFile = File.ReadAllText(fileName);
            //Replace everything except words by null
            str = unchangedFile.Replace("\r","").Replace("\n"," ").Replace("\r\n", " ").Replace(","," ").Replace(")"," ").Replace("(", " ").Replace(";"," ");             //replacing new line charaters

            //str.Split(' ','.',',')
            completeFile = str.Split(' ','.',',', '\r', '\n');             //splitting file into words

            totalWords = completeFile.Length;
            WordCount = 0;

            Console.WriteLine("total words= "+totalWords);
            Htable = new Hashtable();

            //filling hash table with words of file
            for (int i = 0; i < totalWords; i++)
            {
                try
                {

                    string word = getWord().Trim();
                    string key = hashFunction(word);
                    if (((!String.IsNullOrEmpty(word)) && (!String.IsNullOrWhiteSpace(word))))
                    {
                        Word w = new Word(word);
                        if(Htable.ContainsKey(key))//word already exists in hash table means we just have to increament count
                        {
                            w = (Word)Htable[key];
                            w.increment();
                            Htable[key] = w;
                            Console.WriteLine("Word = "+w.word+"  count= "+w.count);
                            nextWord();

                        }
                        else
                        {
                            Console.WriteLine("New Word = " + w.word + "  count= " + w.count);
                            Htable.Add(key, w);
                            nextWord();
                        }


                    }
                    else
                    {
                       // Console.WriteLine("Duplicate key ignored ==>  " + getWord());
                        nextWord();

                    }


                }
                catch (Exception a)
                {
                    Console.WriteLine("REAL EXCEPTION MESSAGE= " + a.Message);
                    
                }
            }


            totalWords = Htable.Count;

        }

        public string hashFunction(string str)
        {
            //97->122
            string r = "";
            str=str.ToLower();
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
                return "";
            }

            
        }

        public void nextWord()
        {
            if (WordCount<totalWords)
            {
                WordCount++;
            }
        }
        /// <summary>
        /// Takes a hash table and compares it with its own hash table and adds 
        /// the common words in passed list 'CommonWords' we assume that list already contains 
        /// all common words and we have to only remove the words which are not found. 
        /// </summary>
        /// <param name="ht"></param>
        /// <param name="CommonWords"></param>
        public void Compare(List<string>CommonWords)
        {
            for(int i=0;i<CommonWords.Count;i++)
            {
                if(!Htable.ContainsValue(CommonWords.ElementAt(i)))
                {
                    CommonWords.RemoveAt(i);//remove uncommon words from common list
                }
            }
        }



        public Report Compare(Hashtable obj,string fileName)
        {
            Console.WriteLine(" COMPARE FUNCTION :");
            Report rp= new Report(this.fileName,fileName);
            foreach(string key in  minHashIndex(obj))
            {
                if(obj.ContainsKey(key) && this.Htable.ContainsKey(key))
                {
                    Word w1 = (Word)this.Htable[key];
                    Word w2= (Word)obj[key];
                    Tuple<string, int, int> t = new Tuple<string, int, int>(w1.word,w1.count,w2.count) ;
                    Console.WriteLine(w1.word+"  " +w1.count+"  " +w2.count);

                    rp.CommonWords.Add(t);
                }
            }

            return rp;
        }

        private ICollection minHashIndex(Hashtable Htable)
        {
            if(this.Htable.Count<=Htable.Count)
            {
                return this.Htable.Keys;
            }
            else
            {
                return Htable.Keys;
            }
        }









    }
}
