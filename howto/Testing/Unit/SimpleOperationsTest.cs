using NUnit.Framework;
using PepoLibrary.Examples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing.Unit
{
    /// <summary>
    /// A basic test case, showing how to execute simple operations
    /// </summary>
    [TestFixture]
    public class SimpleOperationsTest
    {
        [TestCase]
        public void FormatIntegerWithZerosLeftTest()
        {
            string numFormatted = SimpleOperations.FormatIntegerWithZerosLeft(123);
            Assert.IsTrue(numFormatted == "00000123");
        }
    }
}
