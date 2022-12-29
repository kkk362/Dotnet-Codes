using System;
using System.IO;

namespace Day4_FileHandling2
{
    class Ex2
    {
        static void Main()
        {
            string str = @"d:\Day4_FileHandling.exe";
            FileInfo fs = new FileInfo(str);
            if(fs.Exists)
            {
            long a=    fs.Length;
             long b=   a / 1024;
                if (b <= 8)
                {
                    Console.WriteLine("File size in {0} KB=", b);
                    Console.WriteLine("File upload");
                }
                else
                Console.WriteLine("file not upload having more than {0} kb ",b);
            }
            Console.ReadKey();
        }
    }
}
