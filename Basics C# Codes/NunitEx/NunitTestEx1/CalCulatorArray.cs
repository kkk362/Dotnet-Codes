using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MathClassLibrary;

namespace NunitTestEx1
{
    class CalCulatorArray
    {
        [TestCase(new int[] { 2, 4, 6 })]
        public void When_AllNumberAreEven_Expects_AreAllNumbersEvenAsTrue(int[] numbers)
        {
            Calculator number = new  Calculator ();

            bool result = number.AreAllNumbersEven(numbers);

            Assert.That(result == true);
        }
        [TestCase(new int[] { 2, 4, 5 })]
        public void When_AllNumberAreEven_Expects_AreAllNumbersEvenAsTrueFalse(int[] numbers)
        {
            Calculator number = new Calculator();

            bool result = number.AreAllNumbersEven(numbers);

            Assert.That(result == true);
        }
    }
}
