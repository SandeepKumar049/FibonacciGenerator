

    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
 
    [TestClass]
    public class FibonacciTests
    {
        [TestMethod]
        public void TestWith8()
        {
            int l_fib = 8;
            int l_result = FibonacciGenerator.fibonacciCalculator(l_fib);
            Assert.AreEqual(l_result, 13);
        }
 
        [TestMethod]
        public void TestWith20()
        {
            int l_fib = 20;
            int l_result = FibonacciGenerator.fibonacciCalculator(l_fib);
            Assert.AreEqual(l_result, 6765);
        }
 
        [TestMethod]
        public void TestWith0()
        {
            int l_fib = 0;
            int l_result = FibonacciGenerator.fibonacciCalculator(l_fib);
            Assert.AreEqual(l_result, 0);
        }
 
        [TestMethod]
        public void TestWith1()
        {
            int l_fib = 1;
            int l_result = FibonacciGenerator.fibonacciCalculator(l_fib);
            Assert.AreEqual(l_result, 1);
        }
 
 
        [TestMethod]
        public void TestWith2()
        {
            int l_fib = 2;
            int l_result = FibonacciGenerator.fibonacciCalculator(l_fib);
            Assert.AreEqual(l_result, 1);
        }
    }
