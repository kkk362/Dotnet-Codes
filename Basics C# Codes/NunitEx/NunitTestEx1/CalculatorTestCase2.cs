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
    class CalculatorTestCase2
    {
        [TestCase(1,1)]
        [TestCase(3, 6)]
        [TestCase(5, 120)]
        //[Test(6, 120)]  not possiable pass the parameter in Test Attrubute

        public void Factorial_One(int n,int expectedResult)
        {
            Assert.AreEqual(expectedResult, Calculator.Factorial(n));
        }
    }
}
