using System;
using System.IO;

namespace Day4_FileHandling2
{
    class Program
    {
        static void Main()
        {
            string str = @"d:\Day4_FileHandling.exe";
            if (File.Exists(str))
            {
                string name = Path.GetExtension(str);
                if (name == ".exe")
                    Console.WriteLine("file not upload=" + name);
                else
                    Console.WriteLine("file  upload=" + name);
            }
            Console.ReadKey();

        }
    }
}
