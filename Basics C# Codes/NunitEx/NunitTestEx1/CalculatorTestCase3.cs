using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MathClassLibrary;
namespace NunitTestEx1
{

    [TestFixture]
    class CalculatorTestCase3
    {
        [TestCase(1,ExpectedResult= 1)]
        [TestCase(3, ExpectedResult = 6)]
        [TestCase(5, ExpectedResult = 120)]

        public int Factorial_Test(int n)
        {
          return   Calculator .Factorial(n);
        }
        //give the name of the test
        [TestCase(1,TestName ="1!=1", ExpectedResult = 1)]
        [TestCase(3, TestName = "3!=6", ExpectedResult = 6)]
        [TestCase(5, TestName = "5!=120", ExpectedResult = 120)]

        public int Factorial_Test1(int n)
        {
            return Calculator.Factorial(n);
        }
    }
}
