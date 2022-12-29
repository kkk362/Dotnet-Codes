using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
////Nested class

namespace Day2
{
    class Ex6
    {
        static void Main(string[] args)
        {
            A ob = new A();
            Console.WriteLine(ob.mul(4, 5));
            /*
             
             //no error
             */
            A.B ob1 = new A.B(); Console.WriteLine(ob1.add(4, 4));
        }
    }
 internal   class A
    {
        public int mul(int x, int y)
        {
            return x * y;
        }
      internal  class B
        {
            public int add(int x,int y)
            {
                return x + y;
            }
        }
    }
}
