using System;
using System.Collections.Generic;


namespace Day5_1
{
    class Ex2
    {
        static void Main(string[] args)
        {
            List<string> name = new List<string>();//string class--only string value 
            name.Add("Raj");
            List<string> name1 = new List<string>()
            {
                "raj","abhay","kumar"
            };
            foreach(string i in name1)
                Console.WriteLine(i);
            //

        }
     }
}
