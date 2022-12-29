using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTestEx1
{
    /*
     *Generic Test Fixtures
You may also use a generic class as a test fixture. In order for NUnit to instantiate the fixture,
    you must either specify the types to be used as arguments to TestFixtureAttribute or use the 
    named parameter TypeArgs= to specify them. NUnit will construct a separate instance of the 
    fixture for each TestFixtureAttribute you provide.
    The following test fixture would be instantiated by NUnit twice, once using an ArrayList 
    and once using a List<int>.
     */
    [TestFixture(typeof(ArrayList))]
    [TestFixture(typeof(List<int>))]
    public class IList_Tests<TList> where TList : IList, new()
    {
        private IList list;

        [SetUp]
        public void CreateList()
        {
            this.list = new TList();
        }

        [Test]
        public void CanAddToList()
        {
            list.Add(1); list.Add(2); list.Add(3);
            Assert.AreEqual(3, list.Count);
        }
    }
}
