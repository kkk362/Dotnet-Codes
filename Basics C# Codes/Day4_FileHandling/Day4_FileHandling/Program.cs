using System;
using System.IO;//File handling in C#.net--------class,methods,property,constructor,--Indexer

namespace Day4_FileHandling
{
    class Program
    {
        static void Main()
        {
            Test ob = new Test();
         int a=   ob.ss(50, 10);
            Console.WriteLine(a);//5
            int b = ob.ss3(50, 10);
            Console.WriteLine(b);
            // Console.WriteLine("hello");

            Console.Beep(4000, 10000);
            Console.WriteLine("hello");
            /*
             single line ,
             multi line
            */
            //documentation  comment
        }
    }
    class Test
    {
        /// <summary>
        /// divide 2 number
        /// </summary>
        /// <param name="x">int take 4 byte memory</param>
        /// <param name="y">int take 4 byte memory</param>
        /// <returns></returns>
        public int ss(int x,int y)
        { return x / y; }
        /// <summary>
        /// substract two number
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int ss2(int x, int y)
        { return x - y; }
        /// <summary>
        /// add 2 number
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int ss3(int x, int y)
        { return x + y; }
        public int ss5(int x, int y)
        { return x * y; }
        /// <summary>
        /// multiply 2 number
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int ss7(int x, int y)
        { return x / y; }
        public int ss9(int x, int y)
        { return x + y; }
        public int ss10(int x, int y)
        { return x * y; }
    }
    //40:-------1000----10day---------40,000 line
}







