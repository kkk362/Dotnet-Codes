using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MathClassLibrary;

namespace NunitTestEx1
{
    class CalculatorTestOrder
    {
        [Test,Order(1)]
      public void Add()
        {
            Calculator ob = new Calculator();
            Assert.AreEqual(30, ob.addition(5, 25));

        }
        [Test, Order(2)]
        public void Factorial_Zero()
        {
            Assert.AreEqual(1, Calculator.Factorial(0));
        }
        [Test, Order(3)]
        public void Factorial_One()
        {
            Assert.AreEqual(1, Calculator.Factorial(1));
        }
    
    [Test, Order(4)]
    public void Factorial_Three()
        {
            Assert.AreEqual(6, Calculator.Factorial(3));
        }
    
    [Test, Order(5)]
    public void Factorial_Five()
        {
            Assert.AreEqual(120, Calculator.Factorial(5));
        }


    }

}
