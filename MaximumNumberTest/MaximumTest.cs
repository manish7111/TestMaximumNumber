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
            GenericMaximum<int> intMaxValue = new GenericMaximum<int>(225, 100, 24);
            int actualMax = intMaxValue.MaxMethod();
            Assert.AreEqual(225, actualMax);
        }

        /// <summary>
        /// Test case 1.2
        /// </summary>
        [TestMethod]
        public void GivenMaxNumSecondPosition_whenFindMaxNum_shouldReturnsMaxSecond()
        {
            GenericMaximum<int> intMaxValue = new GenericMaximum<int>(225, 375, 157);
            int actualMax = intMaxValue.MaxMethod();
            Assert.AreEqual(375, actualMax);
        }

        /// <summary>
        /// Test case 1.3
        /// </summary>
        [TestMethod]
        public void GivenMaxNumThirdPosition_whenFindMaxNum_shouldReturnsMaxThird()
        {
            GenericMaximum<int> intMaxValue = new GenericMaximum<int>(225, 375, 467);
            int actualMax = intMaxValue.MaxMethod();
            Assert.AreEqual(467, actualMax);
        }

        /// <summary>
        /// Test case 2.1
        /// </summary>
        [TestMethod]
        public void GivenFloatNumFirstPostion_whenFindMax_shouldReturnsMaxFirst()
        {
            GenericMaximum<double> floatMaxValue = new GenericMaximum<double>(55.5, 40.5, 20.5);
            double actualMax = floatMaxValue.MaxMethod();
            Assert.AreEqual(55.5, actualMax);
        }

        /// <summary>
        /// Test case 2.2
        /// </summary>
        [TestMethod]
        public void GivenFloatNumSecondPostion_whenFindMax_shouldReturnsMaxSecondPosition()
        {
            GenericMaximum<double> floatMaxValue = new GenericMaximum<double>(40.5, 55.5, 20.5);
            double actualMax = floatMaxValue.MaxMethod();
            Assert.AreEqual(55.5, actualMax);
        }

        /// <summary>
        /// Test case 2.3
        /// </summary>
        [TestMethod]
        public void GivenFloatNumThirdPostion_whenFindMax_shouldReturnsMaxThirdPosition()
        {
            GenericMaximum<double> floatMaxValue = new GenericMaximum<double>(40.5, 20.5, 55.5);
            double actualMax = floatMaxValue.MaxMethod();
            Assert.AreEqual(55.5, actualMax);
        }

        /// <summary>
        /// Test 3.1
        /// </summary>
        [TestMethod]
        public void GivenMaxStringFirstPositon_whenFindMax_shouldReturnsMaxFirstPosition()
        {
            GenericMaximum<string> stringMaximum = new GenericMaximum<string>("Peach", "Banana", "Apple");
            string actualMax = stringMaximum.MaxMethod();
            Assert.AreEqual("Peach", actualMax);
        }

        /// <summary>
        /// Test 3.2
        /// </summary>
        [TestMethod]
        public void GivenMaxStringSecondPositon_whenFindMax_shouldReturnsMaxSecondPosition()
        {
            GenericMaximum<string> stringMaximum = new GenericMaximum<string>("Banana", "Peach", "Apple");
            string actualMax = stringMaximum.MaxMethod();
            Assert.AreEqual("Peach", actualMax);
        }

        /// <summary>
        /// Test 3.3
        /// </summary>
        [TestMethod]
        public void GivenMaxStringThirdPositon_whenFindMax_shouldReturnsMaxThirdPosition()
        {
            GenericMaximum<string> stringMaximum = new GenericMaximum<string>("Apple", "Banana", "Peach");
            string actualMax = stringMaximum.MaxMethod();
            Assert.AreEqual("Peach", actualMax);
        }
    }
}
