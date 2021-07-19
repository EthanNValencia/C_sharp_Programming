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

            /*
             * System.Array class methods, pg 343-344
             */
            int myIndex = Array.BinarySearch(anArray, 200);
            Console.WriteLine("The Array.BinarySearch returns: " + myIndex);
            Array.Clear(anArray, 1, 1);
            Console.WriteLine("The Array.Clear: " + anArray[1]); // Assigns what is in the specified position to 1. 
            int[] cloneAnArray = (int[]) anArray.Clone(); // Clones the array, but it needs a cast. 
        }
        public void BinarySearch() // Array.BinarySearch example, pg 343
        {
            double[] waterDepth = { 2.4, 3.5, 6.8 };
            double x = 6.8;
            int myIndex = Array.BinarySearch(waterDepth, x);
            Console.WriteLine(myIndex);
        }
        public void Clear() // Array.Clear example, pg 343
        {
            double[] waterDepth = { 2.4, 3.5, 6.8 };
            double x = 6.8;
            Array.Clear(waterDepth, 1, 1);
            Console.WriteLine(waterDepth[1]); // prints 0
        }
        public void Clone() // Array.Clone example, pg 343
        {
            double[] waterDepth = { 2.4, 3.5, 6.8 };
            double[] w = new double[3];
            object o = waterDepth.Clone();
            w = (double[]) o;
        }
        public void Copy() // Array.Copy example, pg 343 
        {
            double[] waterDepth = { 2.4, 3.5, 6.8 };
            double[] w = new double[3];
            Array.Copy(waterDepth, 0, w, 0, 3); // This copies waterDepth to w. 
        }
        public void CopyTo() // Array.CopyTo example, pg 343
        {
            double[] waterDepth = { 2.4, 3.5, 6.8 };
            double[] w = new double[5];
            waterDepth.CopyTo(w, 2); // This copies the array, but it specifies the begin point to index 2. 
            Console.WriteLine(w[3]); // prints 3.5
        }
        public void GetValue() // Array.GetValue example, pg 343 
        {
            double[] waterDepth = { 2.4, 3.5, 6.8 };
            Console.WriteLine(waterDepth.GetValue(1)); // prints 3.5
        }
        public void IndexOf() // Array.IndexOf example, pg 344 
        {
            double[] waterDepth = { 2.4, 3.5, 6.8 };
            int i = Array.IndexOf(waterDepth, 3.5);
            Console.WriteLine(i); // This would print 1 (returns -1 if the value is not found in the array)
        }
        public void LastIndexOf() // Array.LastIndexOf example, pg 344 
        {
            double[] waterDepth = { 2.4, 3.5, 6.8, 2.4 }; // 2.4 occurs at 0 and at 3
            int i = Array.LastIndexOf(waterDepth, 2.4);
            Console.WriteLine(i); // This would print 3 
        }
        public void Reverse() // Array.Reverse example, pg 344 
        {
            double[] waterDepth = { 2.4, 3.5, 6.8 }; 
            Array.Reverse(waterDepth);
            foreach (double wVal in waterDepth)
                Console.Write(wVal + " "); // Displays 6.8 3.5 2.4
        }
        public void SetValue() // Array.SetValue example, pg 344 
        {
            double[] waterDepth = { 2.4, 3.5, 6.8 }; 
            waterDepth.SetValue(55, 0);
            foreach (double wVal in waterDepth)
                Console.Write(wVal + " "); // Displays 55 3.5 2.4
        }
        public void Sort() // Array.Sort example, pg 344 
        {
            double[] waterDepth = { 12.4, 3.5, 6.8 }; 
            Array.Sort(waterDepth);
            foreach (double wVal in waterDepth)
                Console.Write(wVal + " "); // Displays 3.5 6.8 12.4
        }
    }
}
