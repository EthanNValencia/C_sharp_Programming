using System;
using System.Collections.Generic;
using System.Text;

/*
 * Chapter 4 is about methods and their behavior. 
 */

namespace C_sharp_Programming
{
    class Chapter4
    {
        public static void SquareExample()
        {
            int aValue = 786;
            int result;

            result = aValue * aValue;
            Console.WriteLine("{0} sqared is {1}", aValue, result);
            Console.Read();
        }
    }
}
