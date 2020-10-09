using MaximumNumber;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MaximumNumberTest
{
    [TestClass]
    public class MaximumTest
    {
        /// <summary>
        /// Test case 1.1
        /// </summary>
        [TestMethod]
        public void GivenMaxNumFirstPosition_whenFindMaxNum_shouldReturnsMaxFirst()
        {
            int actualMax = MaximumNumberCheck.MaximumIntegerNumber(225, 100, 14);
            Assert.AreEqual(225, actualMax);
        }
        /// <summary>
        /// Test case 1.2
        /// </summary>
        [TestMethod]
        public void GivenMaxNumSecondPosition_whenFindMaxNum_shouldReturnsMaxSecond()
        {
            int actualMax = MaximumNumberCheck.MaximumIntegerNumber(225, 375, 157);
            Assert.AreEqual(375, actualMax);
        }

        /// <summary>
        /// Test case 1.3
        /// </summary>
        [TestMethod]
        public void GivenMaxNumThirdPosition_whenFindMaxNum_shouldReturnsMaxThird()
        {
            int actualMax = MaximumNumberCheck.MaximumIntegerNumber(225, 375, 467);
            Assert.AreEqual(467, actualMax);
        }
    }
}
