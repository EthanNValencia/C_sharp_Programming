using System;
using System.Collections.Generic;
using System.Text;

/* 
 * This is the first thing in C# that I have found to be impressive. Really cool
 * topic. 
 * 
 * Types of paramerters in C#, pg 183
 * 1. ref
 * 2. out
 * 3. params (discussed in chapter 7 with arrays)
 * 
 * OUT and REF allow me to pass variables to data by reference. 
 * Experimenting with this class is a good way to understand how ref and out function. 
 * 
 * Future self: Look at how the data assignment is functioning. The TestDefault() is
 * functioning as you would expect, but the other two methods are operating a little
 * differently. Within the method they are making variable assignments to the testValue 
 * that is outside in the main method. 
 * Normally, in Java, this sort of data assignment would occur when the method returns
 * a parameter. 
 */

namespace C_sharp_Programming
{
    class Chapter4_ParameterClass // Example 4-28, pg 184-185
    {
        public static void TestDefault(int aValue) // This is a normal method and is run first. 
        {
            aValue += 10; // This simply adds 10 to 1
            Console.WriteLine("In TestDefault() - Value: {0}", aValue); 
            /*
             * When program control is returned to the main method, 
             * the aValue is still just 1 in the main method. So 
             * aValue is still 1 in the main method. In order for me
             * to change the value in the main method I would normally
             * have to return a variable and have the variable assigned
             * to the aValue. 
             */
        }

        public static void TestRef(ref int aValue) // The ref parameter type makes this run differently. 
        {
            aValue += 20;
            Console.WriteLine("Inside TestRef() - Value: {0}", aValue);
            /*
             * 
             */
        }

        public static void TestOut(out int aValue) // Changing the parameter type to ref causes an error,  
                                                   // because the argument parameter was never assigned
                                                   // a value. 
        {
            Console.WriteLine("I am inside TestOut(). The value \npassed here was declared, but not \nassigned a numeric.");
            aValue = 13; // Here is where the declared value is assigned a value. 
            Console.WriteLine("In TestOut() = Value: {0}", aValue);
        }

        public static void TestTwoRef(ref int aValue, ref int bValue)
        {
            aValue = 2;
            bValue = 3;
        }

        public static void RunParameterClass()
        {
            int testValue = 1;
            Console.WriteLine("Original Value: {0}", testValue);
            TestDefault(testValue);
            Console.WriteLine("Upon return from TestDefault Value: {0}", testValue);
            Console.WriteLine( );
            
            Console.WriteLine("Original Value: {0}", testValue);
            TestRef(ref testValue); // ref must be passed in with the argument. 
            Console.WriteLine("Upon return from TestRef Value: {0}", testValue);
            Console.WriteLine( );
            
            int testValue2;
            Console.WriteLine("The testValue2 was never assigned a value.");
            TestOut(out testValue2); // out must be passed in with the argument. 
            Console.WriteLine("Upon return from TestOut Value: {0}", testValue2);
            Console.WriteLine( );

            /*
             * Below is a potentionally powerful tool. In a way, the TestTwoRef is
             * returning two data assignments in a single method call. This is something
             * that I have wanted to do in Java, but have to use objects and arrays instead. 
             */
            Console.WriteLine("Before TestTwoRef: testValue is {0} \nand the testValue2 is {1}.", testValue, testValue2);
            TestTwoRef(ref testValue, ref testValue2);
            Console.WriteLine("After TestTwoRef: The testValue is {0} \nand the testValue2 is {1}.", testValue, testValue2);

        }
    }
}
