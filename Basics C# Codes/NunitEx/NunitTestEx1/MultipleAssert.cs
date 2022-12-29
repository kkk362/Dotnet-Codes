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
    class MultipleAssert
    {
      [Test]
        public void Add()
        {
            Calculator ob = new Calculator();
            Assert.AreEqual(30, ob.addition(5, 25));
          
            Assert.AreEqual(10, ob.addition(5, 25));//if any test is fail its not pass the test
        
            

        }
        
    }
}
