using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

///ADD namespace of cv01
using cv01;

///ADD a reference to project name cv01

///set testing class to public -> public class Program

namespace FactorialTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [Timeout(1000)]     ///Add header Timeout
        [ExpectedException(typeof(ArgumentOutOfRangeException))]    ///Expecting ArgumentOutOfRangeException
        public void TestMethod1()
        {
            int inputTest = -1;
            int outputExpected = 120;
            int outputOfFunction = -1;

            outputOfFunction = cv01.Program.Factorial(inputTest);

            Assert.AreEqual(outputExpected, outputOfFunction );
        }
    }
}
