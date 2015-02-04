using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing.Unit
{
    /// <summary>
    /// A sample test
    /// </summary>
    [TestFixture]
    class DummyTest
    {
        int number1;
        int number2;

        [SetUp]
        public void DoThisBeforeTests()
        {
            number1 = 10;
            number2 = 10;
        }

        [TestCase]
        public void NumbersAreEqualTest()
        {
            Assert.IsTrue(number1 == number2);
        }
    }
}
