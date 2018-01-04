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
    }

    public class Solution
    {
        public static bool HasDigitOne(int i)
        {
            throw new System.NotImplementedException();
        }
    }
}
