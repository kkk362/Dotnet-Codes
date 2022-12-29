using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClassLibrary
{
    public class Calculator
    {
        public int addition(int x,int y)
        {
            return x + y;
        }
        public int Divide(int x, int y)
        {
            return x / y;
        }
        public static int Factorial(int n)
        {
            return Enumerable.Range(1, n).Aggregate(1, (x, y) => x * y);

        }
      public bool  AreAllNumbersEven(int[]ar)
        {
            bool a=true ;
            foreach(int i in ar)
            {
                if(i%2==0)
                {
                   a= true;
                }
                else
                {
                    a = false;
                }
            }
            return a;
        }
    }
}
