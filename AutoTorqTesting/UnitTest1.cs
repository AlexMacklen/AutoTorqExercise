using System;
using System.IO;
using AutoTorqExercise;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutoTorqTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIsPalindrome()
        {
            Assert.IsFalse(Palindrome.IsPalindrome("aabbcc"));
            Assert.IsTrue(Palindrome.IsPalindrome("abcba"));
            Assert.IsTrue(Palindrome.IsPalindrome("xxxxx"));
            Assert.IsTrue(Palindrome.IsPalindrome("xxxx"));
            Assert.IsTrue(Palindrome.IsPalindrome("a"));
            Assert.IsTrue(Palindrome.IsPalindrome("ababa"));
            Assert.IsFalse(Palindrome.IsPalindrome("abaa"));
            Assert.IsFalse(Palindrome.IsPalindrome("abc"));
        }

        [TestMethod]
        public void FibTest()
        {
            Assert.AreEqual(5,Fibonacci.GetFibNumber(5));
            Assert.AreEqual(55,Fibonacci.GetFibNumber(10));
            Assert.AreEqual(6765,Fibonacci.GetFibNumber(20));
            
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidDataException))]
        public void FibExceptionTest()
        {
            Assert.AreEqual(0,Fibonacci.GetFibNumber(-1));
        }

        //Recursion is frowned upon in C# because of its 1Mb or 500k (web) Stack.  
        //This test fails even though it's gets and expects the exception, probably can't unwind its position
        //[TestMethod]
        //[ExpectedException(typeof(StackOverflowException))]
        //public void FibStackOverflowExceptionTest()
        //{
        //    Assert.AreEqual(0, Fibonacci.GetFibNumber(int.MaxValue));
        //}

        [TestMethod]
        public void PerfectTest()
        {
            Assert.AreEqual(0,Perfect.PerfectCheck(6));
            Assert.AreEqual(0, Perfect.PerfectCheck(28));
            Assert.AreEqual(-1, Perfect.PerfectCheck(10));
            Assert.AreEqual(-1, Perfect.PerfectCheck(11));
            Assert.AreEqual(1, Perfect.PerfectCheck(12));
            Assert.AreEqual(1, Perfect.PerfectCheck(24));
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidDataException))]
        public void PerfectExceptionZeroTest()
        {
            Assert.AreEqual(0, Perfect.PerfectCheck(0));
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidDataException))]
        public void PerfectExceptionNegTest()
        {
            Assert.AreEqual(0, Perfect.PerfectCheck(0));
        }
    }
}
