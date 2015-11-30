using System;
using SimpleCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCaculatorTests
{
    [TestClass]
    public class EvaluateTests
    {
        [TestMethod]
        public void EvaluateIsReal()
        {
            Evaluate test1 = new Evaluate();
            Assert.IsNotNull(test1);
        }

        [TestMethod]
        public void EvaluateAddition()
        {
            Evaluate test1 = new Evaluate();
            int expected = 6;
            Assert.AreEqual(expected, test1.DoMath("4 + 2"));
        }

        [TestMethod]
        public void EvaluateSubtraction()
        {
            Evaluate test1 = new Evaluate();
            int expected = 2;
            Assert.AreEqual(expected, test1.DoMath("4 - 2"));
        }

        [TestMethod]
        public void EvaluateMultiplication()
        {
            Evaluate test1 = new Evaluate();
            int expected = 8;
            Assert.AreEqual(expected, test1.DoMath("4 * 2"));
        }

        [TestMethod]
        public void EvaluateDivision()
        {
            Evaluate test1 = new Evaluate();
            int expected = 2;
            Assert.AreEqual(expected, test1.DoMath("4 / 2"));
        }

        [TestMethod]
        public void EvaluateModulus()
        {
            Evaluate test1 = new Evaluate();
            int expected = 0;
            Assert.AreEqual(expected, test1.DoMath("4 % 2"));
        }

        [TestMethod]
        public void EvaluateReturnLastQuestion()
        {
            Evaluate test1 = new Evaluate();
            string expected = "2 + 2";
            string actual = test1.lastq("2 + 2");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EvaluateReturnLastAnswer()
        {
            Evaluate test1 = new Evaluate();
            int expected = 4;
            int actual = test1.last("2 + 2");
            Assert.AreEqual(expected, actual);
        }

    }
}
