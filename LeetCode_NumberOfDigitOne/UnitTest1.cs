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
            Assert.IsFalse(Solution.HasDigitOne(0));
        }

        [TestMethod]
        public void HasDigitOne_Input_1_Should_Be_True()
        {
            Assert.IsTrue(Solution.HasDigitOne(1));
        }

        [TestMethod]
        public void HasDigitOne_Input_10_Should_Be_True()
        {
            Assert.IsTrue(Solution.HasDigitOne(10));
        }

        [TestMethod]
        public void Input_1_Should_Be_1()
        {
            Assert.AreEqual(1,Solution.CountDigitOne(1));
        }

    }

    public class Solution
    {
        public static bool HasDigitOne(int i)
        {
            if (i.ToString().Contains("1"))
            {
                return true;
            }
            return false;
        }

        public static int CountDigitOne(int n)
        {
            var result = 0;
            for (int i = 1; i <= n; i++)
            {
                if (HasDigitOne(i))
                {
                    result++;
                }
            }
            return result;
        }
    }
}
