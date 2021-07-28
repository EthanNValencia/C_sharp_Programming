using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Programming
{
    public class Chapter10_GenericExample // Example 10-30 and 10-31, pg 623
    {
        public static void SwapData<E>(ref E first, ref E second)
        {
            E temp;
            temp = first;
            first = second;
            second = temp;
        }

        public static void TestSwap()
        {
            string firstValue = "Programming";
            string secondValue = "C#";
            Console.WriteLine("{0} {1}", firstValue, secondValue); // Prints what is in the first and second string.
            SwapData<string>(ref firstValue, ref secondValue);
            Console.WriteLine("{0} {1}", firstValue, secondValue); // Prints what is in the first and second string.
        }
    }
}
