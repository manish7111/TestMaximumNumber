using MaximumNumber;
using System;

namespace RunMaximumNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 112, 344, 432, 555, 678 };
            GenericMaximum<int> generic = new GenericMaximum<int>(arr);
            generic.PrintMaxValue();
        }
    }
}
