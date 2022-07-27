using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Homework;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTestSubstractOperation
    {
        private readonly double firstNumber = 4.0;
        private double secondNumber = 5.5;
        readonly double expectedResult = -1.5;

        [TestMethod]
        public void SubstarctTwoNumbers()
        {
            Assert.AreEqual(expectedResult, Program.Substract(firstNumber, secondNumber));
        }
    }
}
