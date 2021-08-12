using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file.
        //Test 1
        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(true, true);
        }

        //Test 2
        [TestMethod]
        public void OnlyBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
        }

        //Test3
        [TestMethod]
        public void StringIncasedInBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[LaunchCode]"));
        }

        //Test 4
        [TestMethod]
        public void EmptyStringReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets(""));
        }

        //Test 5
        [TestMethod]
        public void BracketsBeforeStringReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]LaunchCode"));
        }

        //Test 6
        [TestMethod]
        public void BracketsCanBreakUpAStringReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("Launch[Code]"));
        }

        //Test 7
        [TestMethod]
        public void BracketsFacingOppositeWayReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]["));
        }

        //Test 8
        [TestMethod]
        public void TwoSetsOfBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[][]"));
        }

        //Test 9
        [TestMethod]
        public void OnlyOneBracketReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("["));
        }

        //Test 10
        [TestMethod]
        public void DoubleLeftBracketsReturnFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[["));
        }

        //Test 12
        [TestMethod]
        public void DoubleRightBracketsReturnFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]]"));
        }

        //Test 12
        [TestMethod]
        public void BracketsFacingOppositeWayEncasingAWordReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("Launch]Code["));
        }

    }
}

    