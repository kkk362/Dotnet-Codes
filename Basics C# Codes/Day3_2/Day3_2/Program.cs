using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.WriteLine(calculator.ss(2, 3));
            Console.WriteLine(calculator.ss(2L, 3L));
        }
    }
    class Calculator
    {
        public int ss(int x,int y)
        {
            return x + y;
        }
        public int ss(int x, int y,int z)
        {
            return x + y+z;
        }
        public long ss(long x, long y)
        {
            return x * y;
        }
        public string ss(string x, string y)
        {
            return x + y;
        }
    }
}
