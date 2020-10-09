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
            int[] arr = { 225, 100, 24 };
            GenericMaximum<int> intMaxValue = new GenericMaximum<int>(arr);
            int actualMax = intMaxValue.MaxMethod();
            Assert.AreEqual(225, actualMax);
        }

        /// <summary>
        /// Test case 1.2
        /// </summary>
        [TestMethod]
        public void GivenMaxNumSecondPosition_whenFindMaxNum_shouldReturnsMaxSecond()
        {
            int[] arr = { 225, 375, 157 };
            GenericMaximum<int> intMaxValue = new GenericMaximum<int>(arr);
            int actualMax = intMaxValue.MaxMethod();
            Assert.AreEqual(375, actualMax);
        }

        /// <summary>
        /// Test case 1.3
        /// </summary>
        [TestMethod]
        public void GivenMaxNumThirdPosition_whenFindMaxNum_shouldReturnsMaxThird()
        {
            int[] arr = { 225, 375, 467 };
            GenericMaximum<int> intMaxValue = new GenericMaximum<int>(arr);
            int actualMax = intMaxValue.MaxMethod();
            Assert.AreEqual(467, actualMax);
        }

        /// <summary>
        /// Test case 2.1
        /// </summary>
        [TestMethod]
        public void GivenFloatNumFirstPostion_whenFindMax_shouldReturnsMaxFirst()
        {
            double[] arr = { 55.5, 40.5, 20.5 };
            GenericMaximum<double> floatMaxValue = new GenericMaximum<double>(arr);
            double actualMax = floatMaxValue.MaxMethod();
            Assert.AreEqual(55.5, actualMax);
        }

        /// <summary>
        /// Test case 2.2
        /// </summary>
        [TestMethod]
        public void GivenFloatNumSecondPostion_whenFindMax_shouldReturnsMaxSecondPosition()
        {
            double[] arr = { 40.5, 55.5, 20.5 };
            GenericMaximum<double> floatMaxValue = new GenericMaximum<double>(arr);
            double actualMax = floatMaxValue.MaxMethod();
            Assert.AreEqual(55.5, actualMax);
        }

        /// <summary>
        /// Test case 2.3
        /// </summary>
        [TestMethod]
        public void GivenFloatNumThirdPostion_whenFindMax_shouldReturnsMaxThirdPosition()
        {
            double[] arr = { 40.5, 20.5 , 55.5 };
            GenericMaximum<double> floatMaxValue = new GenericMaximum<double>(arr);
            double actualMax = floatMaxValue.MaxMethod();
            Assert.AreEqual(55.5, actualMax);
        }

        /// <summary>
        /// Test 3.1
        /// </summary>
        [TestMethod]
        public void GivenMaxStringFirstPositon_whenFindMax_shouldReturnsMaxFirstPosition()
        {
            string[] arr = { "Peach", "Banana", "Apple" };
            GenericMaximum<string> stringMaxValue = new GenericMaximum<string>(arr);
            string actualMax = stringMaxValue.MaxMethod();
            Assert.AreEqual("Peach", actualMax);
        }

        /// <summary>
        /// Test 3.2
        /// </summary>
        [TestMethod]
        public void GivenMaxStringSecondPositon_whenFindMax_shouldReturnsMaxSecondPosition()
        {
            string[] arr = { "Banana", "Peach", "Apple" };
            GenericMaximum<string> stringMaxValue = new GenericMaximum<string>(arr);
            string actualMax = stringMaxValue.MaxMethod();
            Assert.AreEqual("Peach", actualMax);
        }

        /// <summary>
        /// Test 3.3
        /// </summary>
        [TestMethod]
        public void GivenMaxStringThirdPositon_whenFindMax_shouldReturnsMaxThirdPosition()
        {
            string[] arr = { "Apple", "Banana", "Peach" };
            GenericMaximum<string> stringMaxValue = new GenericMaximum<string>(arr);
            string actualMax = stringMaxValue.MaxMethod();
            Assert.AreEqual("Peach", actualMax);
        }
        /// <summary>
        /// Test case 4.1
        /// </summary>
        [TestMethod]
        public void GivenMoreThreeValue_whenFindMax_shouldReturnsMaxValue()
        {
            int[] arr = { 67, 23, 99, 44 };
            GenericMaximum<int> intMaxValue = new GenericMaximum<int>(arr);
            int actualMax = intMaxValue.MaxMethod();
            Assert.AreEqual(99, actualMax);
        }

        /// <summary>
        /// Test case 4.2
        /// </summary>
        [TestMethod]
        public void GivenMoreThreeValue1_whenFindMax_shouldReturnsMaxValue()
        {
            int[] arr = { 112, 344, 432, 555, 678 };
            GenericMaximum<int> intMaxValue = new GenericMaximum<int>(arr);
            int actualMax = intMaxValue.MaxMethod();
            Assert.AreEqual(678, actualMax);
        }
    }
}
