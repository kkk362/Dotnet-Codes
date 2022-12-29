using System;
using System.IO;

namespace Day4_FileHandling
{
    class FileHandlingEx2
    {
        static void Main()
        {
            string s = @"d:\abc.txt";
                        //create a File ---Ex1
            /*
            if(!File.Exists(s))
            {
                File.CreateText(s);
                Console.WriteLine("File created="+s);
            }
            else
            {
                Console.WriteLine("File exists="+s);

            }
            *
            */
            if(File.Exists(s))
            {
                File.Delete(s);
                Console.WriteLine("File deleted="+s);
            }
            else
            {
                Console.WriteLine("File not found " + s);
            }



        }
     }
}
