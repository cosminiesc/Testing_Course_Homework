using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Homework;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTestDivideOperation
    {
        private readonly double firstNumber = 12.0;
        private double secondNumber = 3.0;
        readonly double expectedResult = 4.0;

        [TestMethod]
        public void DivideTwoNumbers()
        {
            Assert.AreEqual(expectedResult, Program.Divide(firstNumber, secondNumber));
        }
    }
}
