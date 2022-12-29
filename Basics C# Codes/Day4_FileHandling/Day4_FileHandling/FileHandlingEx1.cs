using System;
using System.IO;

namespace Day4_FileHandling
{
    class FileHandlingEx1
    {
       //\n
        static void Main()
        {
          DriveInfo[]dr=  DriveInfo.GetDrives();
            foreach (DriveInfo i in dr)
            {
                Console.WriteLine(i.Name);
                Console.WriteLine("AvailableFreeSpace="+i.AvailableFreeSpace);
                long a = i.AvailableFreeSpace / 1024;
                Console.WriteLine("Size in {0} KB",a);
                Console.WriteLine("TotalSize=" + i.TotalSize);

                if(i.Name==@"D:\")
                    {
                 string[]s=   Directory.GetDirectories(i.Name);

                    foreach(string j in s )
                        Console.WriteLine(j);

                    }

            }

        }
    }
}
