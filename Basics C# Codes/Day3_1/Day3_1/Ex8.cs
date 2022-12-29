using System;
using System.Collections;//Dotnet 1.1

namespace Day3_1
{
    class Ex8
    {
        static void Main(string[] args)
        {
            SortedList sortedList = new SortedList();
            sortedList.Add(1, "Raj");
            sortedList.Add(4, "ram");
            sortedList.Add(2, "abhay");
            sortedList.Add(11, "kumar");
            sortedList.Add(11, "kumar");
            foreach (DictionaryEntry i in sortedList)
            {
                Console.WriteLine("Key="+i.Key+"value="+i.Value);
            }

        }
        }
}
