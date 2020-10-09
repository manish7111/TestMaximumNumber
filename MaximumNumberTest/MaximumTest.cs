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
        /// <summary>
        /// Test case 2.1
        /// </summary>
        [TestMethod]
        public void GivenFloatNumFirstPostion_whenFindMax_shouldReturnsMaxFirst()
        {
            double actualMax = MaximumNumberCheck.MaximumFloatNumber(55.5, 40.5, 20.5);
            Assert.AreEqual(55.5, actualMax);
        }

        /// <summary>
        /// Test case 2.2
        /// </summary>
        [TestMethod]
        public void GivenFloatNumSecondPostion_whenFindMax_shouldReturnsMaxSecondPosition()
        {
            double actualMax = MaximumNumberCheck.MaximumFloatNumber(40.5, 55.5, 20.5);
            Assert.AreEqual(55.5, actualMax);
        }

        /// <summary>
        /// Test case 2.3
        /// </summary>
        [TestMethod]
        public void GivenFloatNumThirdPostion_whenFindMax_shouldReturnsMaxThirdPosition()
        {
            double actualMax = MaximumNumberCheck.MaximumFloatNumber(40.5, 20.5, 55.5);
            Assert.AreEqual(55.5, actualMax);
        }
    }
}
