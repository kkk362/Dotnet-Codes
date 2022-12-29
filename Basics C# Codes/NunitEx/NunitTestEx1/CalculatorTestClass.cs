using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathClassLibrary;
using NUnit.Framework;


namespace NunitTestEx1
{

    [TestFixture]
    class CalculatorTestClass
    {
       [TestCase]
       public void Add()
        {
            Calculator ob = new Calculator();
            Assert.AreEqual(30, ob.addition(5, 25));

        }
        [Test]
        public void Factorial_Zero()
        {
            Assert.AreEqual(1, Calculator.Factorial(0));
        }
        [Test]
        public void Factorial_One()
        {
            Assert.AreEqual(1, Calculator.Factorial(1));
        }
        [Test]
        public void Factorial_Three()
        {
            Assert.AreEqual(6, Calculator.Factorial(3));
        }
        [Test]
        public void Factorial_Five()
        {
            Assert.AreEqual(120, Calculator.Factorial(5));
        }
    }
}
