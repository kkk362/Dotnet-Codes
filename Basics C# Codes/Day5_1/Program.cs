using System;
namespace Day5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Test ob = new Test();
            Console.WriteLine(ob.FirstName);
            ob.FirstName = "Kumar";
            Console.WriteLine(ob.FirstName);
            //We have to pass object index using Indexer
            Test test = new Test();
            Console.WriteLine(test[1]);//MI
            test[1] = "RCB";//Indexer can not be static 
            Console.WriteLine(test[1]);
           
        }
    }
    class Test
    {
        string[] TeamName = { "CSK", "MI", "XY", "WD" };
        public string this[int index]
        {
            get
            {
                return TeamName[index];
            }
            set
            {
                TeamName[index] = value;

            }
        }
        string Fname = "Raj kumar";
        public string FirstName
        {
            get
            {
                return Fname;
            }
            set
            {
                Fname = value;

            }
        }

    }
}
