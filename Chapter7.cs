using System;
using System.Collections.Generic;
using System.Text;

/*
 * Arrays and Collections, pg 329
 * - Learn array basics
 * - Declare arrays and perform compile-time initialization of array elements. 
 * - Access elements of an array.
 * - Become familiar with methods of the Array class.
 * - Write methods that use arrays as parameters. 
 * - Write classes that include arrays as members and instantiate user-defined array objects.
 * - Create two-dimentional arrays including rectangular and jagged types. 
 * - Use mulitdimensional arrays. 
 * - Use the ArrayList class to create dynamic lists. 
 * - Learn about the predefined methods of the string class. 
 * - Be introduced to the other collection classes. 
 * - Work through programming example that illustrates the chapter's concepts. 
 * 
 * In C#, all arrays are objects of the base type. 
 * Like Java, the length of an array cannot be changed. 
 */
namespace C_sharp_Programming
{
    class Chapter7
    {
        public void ArrayBasics()
        {
            int[] intArray; // Array can be declared without having its size specified. 
            intArray = new int[14]; // Array is instantiated, the size is specified.

            // Example 7-3, pg 335
            int[] anArray = { 100, 200, 300, 400, 600 };
            char[] grade = new char[] { 'A', 'B', 'C', 'D', 'F' }; 
            double[] depth = new double[2] { 2.5, 3 }; // Size is stated and input is provided. I don't really ever do this.  
            // double[] waterDepth = new double[3] { 2, 3 }; // This causes an error, because the size is 3, but only 2 numbers are provided. 

            // Example 7-8, pg 342
            int total = 0;
            double avg;
            int[] score = { 3, 5, 1, 24, 52, 3, 90, 70, 80, 60 };
            foreach (int val in score) // Using an enhanced loop to go through an array.
            {
                total += val;
            }
            Console.WriteLine("Sum of the score array is: {0}", total);
        }
    }
}
