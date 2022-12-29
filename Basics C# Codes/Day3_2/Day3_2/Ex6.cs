using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_2
{
    interface X
    {
        int ss(int x, int y);// *
    }
    interface Y
    {
        int ss(int x, int y);//   divide
    }
    class Z:X,Y 
    {
         int X.ss(int x,int y)
        {
            return x * y;
        }
         int Y.ss(int x, int y)
        {
            return x / y;
        }
    }
    class Ex6
    {
       
        static void Main(string[] args)
        {
            X ob = new Z(); Console.WriteLine(ob.ss(6,2));
            Y ob1 = new Z(); Console.WriteLine(ob1.ss(6, 2));
            Z ob2 = new Z(); //no method
        }
    }
}
