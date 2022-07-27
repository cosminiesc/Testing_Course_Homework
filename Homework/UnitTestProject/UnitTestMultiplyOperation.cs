using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Homework;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTestMultiplyOperation
    {
        private readonly double firstNumber = 9.0;
        private double secondNumber = 6.5;
        readonly double expectedResult = 58.5;

        [TestMethod]
        public void MultyplyTwoNumbers()
        {
            Assert.AreEqual(expectedResult, Program.Multiply(firstNumber, secondNumber));
        }
    }
}
