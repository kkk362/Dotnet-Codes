using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_1
{
    class Ex2
    {
        static void Main(string[] args)
        {
            string[] name = { "raj", "abhay", "kumar", "subham" };
            Console.WriteLine("Asc Order");
            Array.Sort(name);
            foreach(string i in name)
                Console.WriteLine(i);
            Console.WriteLine("Reverse Order");
            Array.Reverse(name);
            foreach (string i in name)
                Console.WriteLine(i);



            //Array---Provide a Fix Collection,Array is class in System
            //ArrayList----Provide a Dynamic Collection,ArrayList-System.Collections
        }
    }
}
