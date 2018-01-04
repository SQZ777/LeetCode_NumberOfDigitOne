using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode_NumberOfDigitOne
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void HasDigitOne_Input_0_Should_Be_false()
        {
            Assert.AreEqual(0, Solution.HasDigitOne(0));
        }

        [TestMethod]
        public void HasDigitOne_Input_1_Should_Be_True()
        {
            Assert.AreEqual(1, Solution.HasDigitOne(1));
        }

        [TestMethod]
        public void HasDigitOne_Input_10_Should_Be_True()
        {
            Assert.AreEqual(1, Solution.HasDigitOne(10));
        }

        [TestMethod]
        public void Input_1_Should_Be_1()
        {
            Assert.AreEqual(1, Solution.CountDigitOne(1));
        }

        [TestMethod]
        public void Input_10_Should_Be_2()
        {
            Assert.AreEqual(2, Solution.CountDigitOne(10));
        }

        [TestMethod]
        public void Input_f1_Should_Be_0()
        {
            Assert.AreEqual(0, Solution.CountDigitOne(-1));
        }

        [TestMethod]
        public void Input_11_Should_Be_4()
        {
            Assert.AreEqual(4, Solution.CountDigitOne(11));
        }

        public void Input_824883294_Should_Be_654()
        {
            Assert.AreEqual(1, Solution.CountDigitOne(824883294));
        }
    }

    public class Solution
    {
        public static int HasDigitOne(int i)
        {
            return i.ToString().Count(x => x == '1');
        }

        public static int CountDigitOne(int n)
        {
          return n > 0 ? Enumerable.Range(1, n).Sum(HasDigitOne) : 0;
        }
    }
}
