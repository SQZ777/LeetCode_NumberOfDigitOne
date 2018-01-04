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
    }
}
