using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_2
{   interface A
    {  int ss(int x, int y);
    }
    interface B
    {
        int Mul(int x, int y);
    }
    class C : A, B
    {
        public int ss(int x,int y)
        {
            return x + y;
        }
        public int Mul(int x, int y)
        {
            return x * y;
        }

    }
    class Ex5
    {
        static void Main(string[] args)
        {
            A ob = new C(); Console.WriteLine(ob.ss(4, 2));
            B ob1 = new C(); Console.WriteLine(ob1.Mul(4, 2));
          
        }
    }
}
