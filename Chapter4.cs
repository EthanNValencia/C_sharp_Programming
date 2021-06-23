using System;
using System.Collections.Generic;
using System.Text;

/*
 * Chapter 4 is about methods and their behavior.
 * Definitions
 * Example: public void ReturnSqrt(double num) {}
 * Method Parameters: These are the datatypes that a method takes. "(double num)" double is the parameter
 * Method Arguments: These are the specific variables that are passed in a method call. "ReturnSqrt(25);" 25 is the argument
 * Method Signature: This the full signature of the method. 
 * 
 * Methods can be overloaded to have many different method signatures. Ex: ReturnSqrt(double), ReturnSqrt(int), etc
 * When C# runs it using the argument type to determine which overloaded method siganture is to be used. 
 * If I pass a double to ReturnSqrt(), then it will match with the overloaded method that requires a parameter
 * of type double. 
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
            return; // nothing is returned 
        }

        public static double CalculateMilesPerGallon(int milesTraveled, double gallonsUsed) // Example 4-3, pg 141
        {
            return milesTraveled / gallonsUsed;
        }

        public static void PrintExample() // Example pg 145
        {
            /*
             * This example is meant to highlight how different arguments are passed into 
             * the WriteLine() method. 
             * The method call includes 4 arguments:
             * 1. "Value0({0}) + Value1({1}) = Value2({2})"
             * 2. 25
             * 3. 75
             * 4. (25+75)
             */
            Console.WriteLine("Value0({0}) + Value1({1}) = Value2({2})", 25, 75, (25+75));
            /*
             * This method call does the same thing as the above method call. However,
             * the arguments are methods that return the desired variables. 
             */
            Console.WriteLine("Value0({0}) + Value1({1}) = Value2({2})", ReturnTwentyFive(), ReturnSeventyFive(), (ReturnTwentyFive() + ReturnSeventyFive()));
            
        }
        public static int ReturnTwentyFive()
        {
            return 25;
        }
        public static int ReturnSeventyFive()
        {
            return 75; 
        }

        public static void CastingCharExample() // Example 4-7 pg 150
        {
            int aNumber = 97;
            Console.WriteLine("The value of aNumber is: " + aNumber);
            Console.WriteLine("The value of aNumber is: " + (char) aNumber + " (97 casted as a char)");
        }

        public static void UsingReadInAWriteLine()
        {
            Console.WriteLine("The valued entered is: " + Console.Read()); // This doesn't get the correct number? Kind of weird. 
        }

        public static void MathClassExamples() // Example 4-12, pg 159
        {
            int aValue = 200;
            int bValue = 896;
            int result;
            result = Math.Max(aValue, bValue); // result == 896 (896 is larger than 200)
            result += bValue * Math.Max(aValue, bValue) - aValue; // Result == 896 + (896 * 896 - 200) == 803512
            Console.WriteLine("Largest value between {0} and {1} is {2}", aValue, bValue, Math.Max(aValue, bValue));
            return; // While the return is option in this case, some people think it makes the code more readable. 
        }
    }
}
