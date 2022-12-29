using System;
using System.IO;

namespace Day4_FileHandling
{
    class FileHandlingEx4
    {
        static void Main()
        {
            string file = @"d:\myFile13.txt";
            if(File.Exists(file))
            {
                FileStream fs = new FileStream(file, FileMode.Open, FileAccess.ReadWrite);
                StreamReader streamReader = new StreamReader(fs);
             string content=   streamReader.ReadToEnd();
                Console.WriteLine(content);
                streamReader.Close();
                fs.Close();
            }
            else

                Console.WriteLine("File not found="+file);
            Console.ReadKey();

        }
    }
}
