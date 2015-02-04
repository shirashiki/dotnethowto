using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PepoLibrary.Examples
{
    /// <summary>
    /// A class containing examples of simple operations. DON'T USE THIS AS A LIBRARY.
    /// This is just to illustrate use, ok?
    /// 
    /// See tests in test project, SimpleOperationsTest
    /// </summary>
    public class SimpleOperations
    {

        /// <summary>
        /// Example: formats number with zeros in the left
        /// </summary>
        /// <returns></returns>
        public static string FormatIntegerWithZerosLeft(int intNumber)
        {
            return intNumber.ToString("D8");
        }
    }
}
