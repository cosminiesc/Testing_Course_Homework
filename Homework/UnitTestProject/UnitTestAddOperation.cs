using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Homework;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTestAddOperation
    {
        private readonly double firstNumber = 4.0;
        private double secondNumber = 5.5;
        readonly double expectedResult = 9.5;

        [TestMethod]
        public void AddTwoNumbers()
        {
            Assert.AreEqual(expectedResult, Program.Add(firstNumber, secondNumber));
        }
    }
}
