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
        /*
         * C# has several types of access modifiers. Some are the same as Java but some are different. pg. 140
         * 1. public                - no restrictions
         * 2. protected             - limited access to the containing class or classes derived from the class
         * 3. internal              - limited to current project
         * 4. protected internal    - limited to current project or classes derived from the class
         * 5. private               - Limited to the containing class
         * internal and protected internal are access modifiers that are not included in Java. 
         * If the access modifier is not specified then it is implied to be private by default. 
         */
        public static void SquareExample()
        {
            int aValue = 768;
            int result;

            result = aValue * aValue;
            Console.WriteLine("{0} sqared is {1:N0}", aValue, result); // N0 adds a coma to the numerical format. 
            // Console.Read(); 
        }

        public static double CalculateMilesPerGallon(int milesTraveled, double gallonsUsed) // Example 4-3, pg 141
        {
            return milesTraveled / gallonsUsed;
        }
    }
}
