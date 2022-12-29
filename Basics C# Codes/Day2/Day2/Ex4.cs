using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Ex4
    {
        static void Main(string[] args)
        {
            Myclass myclass = new Myclass(5);//20 hello 25
        }
    }
    class Myclass
    {
        private Myclass():this(4,5)
        {
            Console.WriteLine("hello");
        }
        public Myclass(int x):this()
        {
            Console.WriteLine(x*5);
        }
        private Myclass(int x,int y)
        {
            Console.WriteLine(x*y);
        }
    }
    //class Myclass1:Myclass
    //{
    //    private Myclass1()
    //    {
    //        Console.WriteLine("hello1");
    //    }
    //}
}
