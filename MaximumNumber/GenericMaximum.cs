using System;
using System.Collections.Generic;
using System.Text;

namespace MaximumNumber
{
    public class GenericMaximum<T> where T : IComparable
    {
        public T[] value;
        /// <summary>
        /// This method is created for initialize the constructor of instance variable
        /// </summary>
        /// <param name="input_val1"></param>
        /// <param name="input_val2"></param>
        /// <param name="input_val3"></param>
        public GenericMaximum(T[] value)
        {
            this.value = value;
        }
        /// <summary>
        /// This method is created for sorting the values
        /// </summary>
        /// <param name="values"></param>
        /// <returns>sortedValue</returns>
        public T[] Sort(T[] values)
        {
            Array.Sort(values);
            return values;
        }
        /// <summary>
        /// This method is created for finding max for given type
        /// params is used for optional
        /// </summary>
        /// <param name="val1"></param>
        /// <param name="val2"></param>
        /// <param name="val3"></param>
        /// <returns></returns>
        public T MaxValue(params T[] values)
        {
            var sorted_values = Sort(values);
            return sorted_values[^1];
        }
        /// <summary>
        /// This method is created calling maxvalue method
        /// </summary>
        /// <returns>max</returns>
        public T MaxMethod()
        {
            var max = MaxValue(this.value);
            return max;
        }
        /// <summary>
        /// This method is printing maximum generic value
        /// </summary>
        /// <param name="values"></param>
        public void PrintMaxValue()
        {
            var max = MaxValue(this.value);
            Console.WriteLine("Maximum value is " + max);
        }
    }
}
