using System;
using System.IO;

namespace Day4_FileHandling
{
    class FileHandlingEx3
    {
        static void Main()
        {
            string file = @"d:\myFile14.txt";
            if(!File.Exists(file))
            {
                FileStream fs = new FileStream(file, FileMode.Create, FileAccess.Write);
                StreamWriter streamWriter = new StreamWriter(fs);
                streamWriter.WriteLine("Hello My Name is Raj");
                streamWriter.Close();//save the content inside the file;
                fs.Close();
                Console.WriteLine("File created="+file);


            }
            else
            {
                Console.WriteLine("file exits="+file);
            }

        }
    }
}
