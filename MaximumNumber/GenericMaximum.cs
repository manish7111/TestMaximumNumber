using System;
using System.Collections.Generic;
using System.Text;

namespace MaximumNumber
{
    public class GenericMaximum<T> where T : IComparable
    {
        public T firstValue, secondValue, thirdValue;
        /// <summary>
        /// This method is created for initialize the constructor of instance variable
        /// </summary>
        /// <param name="input_val1"></param>
        /// <param name="input_val2"></param>
        /// <param name="input_val3"></param>
        public GenericMaximum(T firstValue, T secondValue, T thirdValue)
        {
            this.firstValue = firstValue;
            this.secondValue = secondValue;
            this.thirdValue = thirdValue;
        }
        /// <summary>
        /// This method is created for finding max for given type
        /// </summary>
        /// <param name="val1"></param>
        /// <param name="val2"></param>
        /// <param name="val3"></param>
        /// <returns></returns>
        public static T MaxValue(T firstValue, T secondValue, T thirdValue)
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0 ||
                firstValue.CompareTo(secondValue) >= 0 && firstValue.CompareTo(thirdValue) > 0 ||
                firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) >= 0)
            {
                return firstValue;
            }
            if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0 ||
                secondValue.CompareTo(firstValue) >= 0 && secondValue.CompareTo(thirdValue) > 0 ||
                secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) >= 0)
            {
                return secondValue;
            }
            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0 ||
                thirdValue.CompareTo(firstValue) >= 0 && thirdValue.CompareTo(secondValue) > 0 ||
                thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) >= 0)
            {
                return thirdValue;
            }
            return default;
        }
        /// <summary>
        /// This method is created calling maxvalue method
        /// </summary>
        /// <returns>max</returns>
        public T MaxMethod()
        {
            T max = GenericMaximum<T>.MaxValue(firstValue, secondValue, thirdValue);
            return max;
        }
    }
}
