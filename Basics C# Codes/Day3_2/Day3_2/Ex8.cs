using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_2
{
    class MyClass1
    {
        public virtual void show()
        {
            Console.WriteLine("hello Raj");
        }
    }
    class MyClass2:MyClass1
    {
        public sealed  override void show()
        {
            Console.WriteLine("hello Rajee");
        }
    }
    class MyClass3:MyClass2
    {
        //public override void show()
        //{
        //    Console.WriteLine("hello Kumar");
        //}

    }
    class Ex8
    {
        static void Main(string[] args)
        {
        }
    }
}
