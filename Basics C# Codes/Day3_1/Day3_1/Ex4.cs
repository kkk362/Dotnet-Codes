using System;
using System.Collections;

namespace Day3_1
{
    class Ex4
    {
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();
            ar.Add("Raj");
            ar.Add("Abhay");
            ar.Add("Kumar");
            ar.Add("Subham");
            ar.Add("Shyham");
            Console.WriteLine("Sorting=============");
            ar.Sort();
            foreach(string i in ar)
                Console.WriteLine(i);
            Console.WriteLine("Reverse=============");
            ar.Reverse();
            foreach (string i in ar)
                Console.WriteLine(i);
            ar.RemoveAt(1);
            if (ar.Contains("Raj1"))
            {
                ar.Remove("Raj1");
            }
            else
                Console.WriteLine("Name not found");

            //11,22,33,55,66
            ar.RemoveRange(1, 2);


        }
   }
}
