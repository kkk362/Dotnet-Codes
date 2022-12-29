using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    //Swap Two values
    class Ex2
    {
        static void Main(string[] args)
        {
            int a = 100;
            int b = 1000;
            Test test = new Test();
            test.Swap(ref a,ref b);
            Console.WriteLine("a={0} b={1}",a,b);
            string s = "Raj";
            string s1 = "Kumar";
            test.Swap(ref s,ref  s1);
            Console.WriteLine("s={0} s1={1}", s, s1);




        }
     }
    class Test
    {
        public void Swap<T>(ref  T  a,ref T  b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
       
    }

}
