using System;
using SimpleCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCaculatorTests
{
    [TestClass]
    public class StackTests
    {
        [TestMethod]
        public void StackExists()
        {
            Stack test1 = new Stack();
        }
        
        [TestMethod]
        public void StackCanHoldLastQuestion()
        {
            Stack test1 = new Stack();
            test1.lastq = "1 + 1";
            string expected = "1 + 1";
            Assert.AreEqual(expected, test1.lastq);
        }

        [TestMethod]
        public void StackCanHoldLastAnswer()
        {
            Stack test1 = new Stack();
            test1.last = 2;
            int expected = 2;
            Assert.AreEqual(expected, test1.last);
        }

        [TestMethod]
        public void StackACanBeAConstant()
        {
            Stack test1 = new Stack();
            test1.constants.Add('a', 1);
            int value;
            bool expected = test1.constants.TryGetValue('a', out value);
            Assert.IsTrue(expected);
            Assert.AreEqual(1, value);
        }

        [TestMethod]
        public void StackConstantsAreCaseInsensitive()
        {
            Stack test1 = new Stack();
            test1.MyAdd('A', 2);
            int value;
            bool expected = test1.constants.TryGetValue('a', out value);
            Assert.AreEqual(2, value);
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void StackConstantAlreadyDefined()
        {
            Stack test1 = new Stack();
            test1.MyAdd('a', 9);
            test1.MyAdd('A', 2);
            int value;
            bool expected = test1.constants.TryGetValue('a', out value);
            Assert.AreEqual(2, value);
        }
    }
}
