using System;
using System.Collections.Generic;
namespace Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyGeneric<int> obj = new MyGeneric<int>(10);
          int ar=  obj.genericMethod(10);
            Console.WriteLine(ar);
            MyGeneric<string> obj1 = new MyGeneric<string>("raj");
         string str=   obj1.genericMethod("kumar");
            Console.WriteLine(str);



        }
    }
    class MyGeneric<T>
    {
        private T GnVariable;
        public MyGeneric( T value)
        {
            GnVariable = value;
        }
        public T genericMethod(T gerparameter)
        {
            return GnVariable;
        }
        public T genProperty { get; set; }
    }
}
