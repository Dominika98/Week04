using System;
using System.IO;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var sr = new StreamReader("new.txt"))
            {
                string line;
                int number = 0;
                string word = "";
                while((line = sr.ReadLine()) != null)
                {
                    Array a = line.Split(" ");
                    number += a.Length;
                    foreach(String sth in a)
                    {
                        
                        if(word.ToCharArray().Length < sth.ToCharArray().Length)
                        {
                            word = sth;
                        }
                    }
                }

                System.Console.WriteLine("The text has " + number + " words.");
                System.Console.WriteLine("The longest word is: " + word);
            }
        }
    }
}
