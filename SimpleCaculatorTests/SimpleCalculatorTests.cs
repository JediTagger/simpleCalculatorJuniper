using System;
using SimpleCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCaculatorTests
{
    [TestClass]
    public class SimpleCalculatorTests
    {
        [TestMethod]
        public void ParseClassExists()
        {
            Parse test1 = new Parse();
            Assert.IsNotNull(test1);
        }

        [TestMethod]
        public void ParseCanReturnOperator()
        {
            Parse test1 = new Parse();
            string test2 = test1.ExtractOperator("1 + 1");
            Assert.AreEqual("+", test2);
        }

        [TestMethod]
        public void ParseCanExtractTerms()
        {
            Parse test1 = new Parse();
            int[] expected_terms = test1.ExtractTerms("1 + 1");
            Assert.IsInstanceOfType(expected_terms, typeof(Int32[]));
            CollectionAssert.AreEqual(expected_terms, new int[] { 1, 1 });
            //or
            int[] example_terms = new int[] { 1, 1 };
            CollectionAssert.AreEqual(expected_terms, example_terms);
        }
        
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ParseThrowsExceptionForBadOperator()
        {
            Parse test1 = new Parse();
            string thisOperator = test1.ExtractOperator("1 1 1");
            Assert.AreEqual(thisOperator, 1);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ParseThrowsExceptionForBadTerms()
        {
            Parse test1 = new Parse();
            int[] expected_terms = test1.ExtractTerms("1 + a");
            Assert.AreEqual(expected_terms, new int[] { 1, 1 });
        }

    }
}
