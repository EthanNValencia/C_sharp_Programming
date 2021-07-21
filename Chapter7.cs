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
 * 
 * The array idfentifer memory location does not actually contain the values of the array, 
 * but rather an address indicating the location of the elements in the array. 
 * 
 * Array objects and string types contain a reference to the location of the stored values. 
 * 
 * Normally, the problem with reference types is that they can be compared with equality operators, because
 * they would be comparing the reference rather than the actual value that the reference refers to.
 * 
 * In C#, a string is a reference type, but the compiler understands that when used with equality operators, 
 * it should compare the contents or values rather than the reference. 
 * 
 * Strings are immutable. This means that when a string is changed it is an entirely new address location
 * in the computers memory. Pg 376-38 offer a good chart that shows the string methods with examples. 
 * 
 * StringBuilder class has many of the same traits as a string, but it can be used as a mutable string. 
 * 
 * -- Other types of Collections --
 * BitArray     - stores a group of bit values represented as booleans (true or false)
 * HashTable    - represents a collection of key/value pairs that are organized based on the hashcode of the key. 
 * Queue        - A First In First Out collection of objects. 
 * Stack        - A Last in First Out collection of objects. 
 * SortedList   - A collection of key/value pairs that are sorted by the keys are accessed by key and by index.
 * Dictionary   - A collection that provides a mapping from a set of keys to a set of values. 
 * 
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

        public void VaryingArguments() // Example 7-14, pg 353
        {
            DisplayItems(1, 2, 3, 5); // 1 2 3 4
            int[] anArray = new int[5] { 100, 200, 300, 400, 500 };
            DisplayItems(anArray); // 100 200 300 400 500 
            DisplayItems(1500, anArray[1] * anArray[2]); // 1500 60000
            DisplayItems(1); // 1
        }
        /*
         * This is an example of how the params array can be used. This means that the number of arguments 
         * that are passed to the method may vary. This is cool, because instead of specifying a single
         * int, the method can take a single argument, but it can also take several in the form of 
         * an array. 
         */
        public void DisplayItems(params int[] item) // This is really cool. I learned how to do this in Java too!
        {
            for (int i = 0; i < item.Length; i++)
            {
                Console.Write(item[i] + " ");
            }
            Console.WriteLine("\n");
        }

        public void TwoDimensionalSquareArray() // This is a square 2D array. 
        {
            int[,] calories = new int[7, 3]; // How to declare a 2D square array. 
            int[,] cal = { { 900, 750, 1020}, { 300, 1000, 2700}, { 500, 700, 2100},
                           { 400, 900, 1780}, { 600, 1200, 1100 }, { 575, 1150, 1900},
                           { 600, 1020, 1700} };
            Console.WriteLine("The first side is {0}, the second side is {1}, and the total size is {2}.", cal.GetLength(0), cal.GetLength(1), cal.Length);
            Console.WriteLine("The rank of the array is {0}. Rank is the dimension.", cal.Rank);
            Console.WriteLine("First array: the upper bound is {0}. The lower bound is {1}.", cal.GetUpperBound(0), cal.GetLowerBound(0));
            Console.WriteLine("Second array: the upper bound is {0}. The lower bound is {1}.", cal.GetUpperBound(1), cal.GetLowerBound(1));
            Console.Write("--2 Dimensional Array--");
            for (int i = 0; i < cal.GetLength(0); i++)
            {
                // This will be executed 7 times, cal[7,3].
                Console.WriteLine();
                for (int j = 0; j < cal.GetLength(1); j++)
                {
                    Console.Write(cal[i, j] + "  "); // This is executed 21 times, 7*3.
                }
            }
            Console.WriteLine("\n");
            /* The 2D array is printed out. 
             * 900  750  1020
             * 300  1000  2700
             * 500  700  2100
             * 400  900  1780
             * 600  1200  1100
             * 575  1150  1900
             * 600  1020  1700 
             */
        }
        public void JaggedArrayExample() // Example 7-16, pg 367
        {
            int[][] anArray = new int[4][]; // Jagged arrays are declared differently. 
            anArray[0] = new int[] { 100, 200 };
            anArray[1] = new int[] { 11, 22, 37 };
            anArray[2] = new int[] { 16, 72, 83, 99, 106 };
            anArray[3] = new int[] { 1, 2, 3, 4 };
            for(int i = 0; i < anArray.GetLength(0); i++) 
            {
                Console.WriteLine();
                for (int j = 0; j < anArray[i].Length; j++) 
                {
                    Console.Write(anArray[i][j] + " ");
                }
            }
        }
        public void ThreeDimensionalSquareArray()
        {
            int[,,] daysInMonth = new int[ 3, 4, 7 ];
            int dayCounter = 0, printCounter = 0;
            for(int month = 0; month < daysInMonth.GetLength(0); month++)
            {
                dayCounter = 0;
                for (int week = 0; week < daysInMonth.GetLength(1); week++)
                {
                    for(int day = 0; day < daysInMonth.GetLength(2); day++)
                    {
                        dayCounter++;
                        daysInMonth[month, week, day] = dayCounter; 
                    }
                }
            }

            for (int week = 0; week < daysInMonth.GetLength(0); week++)
            {
                Console.WriteLine();
                for (int day = 0; day < daysInMonth.GetLength(1); day++)
                {
                    Console.WriteLine();
                    for (int month = 0; month < daysInMonth.GetLength(2); month++)
                    {
                        Console.Write(daysInMonth[week, day, month] + " ");
                    }
                }
            }
        }
        /*
         * Some of the ArrayList methods, pg 373, this is very similar to Java
         * 
         * Add()            - Adds a value onto the end. 
         * BinarySearch()   - Uses binary search to locate a value. 
         * Capacity         - Gets or sets the number of elements that the ArrayList can contains.
         * Clear()          - Removes all elements.
         * Clone()          - Creates a copy. 
         * Contains()       - Determines whether an element is in the ArrayList.
         * Count            - Gets or sets the number of elements that the ArrayList actually contains. 
         * GetRange()       - Returns an ArrayList that is a subset of another ArrayList. 
         * IndexOf()        - Returns the index of the first occurence of a value. 
         * Insert()         - Inserts an element at a specified index. 
         * InsertRange()    - Inserts the elements of an ArrayList into another ArrayList at the specified index.
         * Item             - Gets or sets the element at the specified index. 
         * LastIndexOf()    - Returns the index of the last occurence of a value. 
         * Remove()         - Removes the first occurence of a specified object. 
         * RemoveAt()       - Removes the element at the specified index. 
         * RemoveRange()    - Removes a range of elements. 
         * Repeat()         - Returns an ArrayList whose elements are copies of the specified value. 
         * Reverse()        - Reverses the order of the elements. 
         * Sort()           - Sorts the elements or a porition of them. 
         * ToArray()        - Copies the elements to a new array. 
         * TrimToSize()     - Sets the capacity to the actual number of elements. 
         * 
         */

        public void Question7() // pg 393
        {
            char[,] n = { { 'a', 'b', 'c', 'd', 'e' }, { 'f', 'g', 'h', 'i', 'j' } };
            Console.WriteLine(n[1, 1]); // g
            Console.WriteLine(n[0, 4]); // e
            Console.WriteLine(n[1, 3]); // i
        }
        public void Question12() // pg 394
        {
            int i;
            int[] anArray = new int[5];
            for (i = 0; i < anArray.Length; i++)
                anArray[i] = 2 * i;
            for (i = 0; i < anArray.Length; i++)
                Console.Write(anArray[i] + " ");
            Console.WriteLine();
        }
        public void Question15() // pg 395
        {
            int[,] points = { { 300, 100, 200, 400, 600 }, { 550, 700, 900, 200, 100 } };
            points[0, 4] = points[0, 4 - 2];
            Console.WriteLine(points[0, 4]); // 200
        }
        public void Question16() // pg 395
        {
            int[,] points = { { 300, 100, 200, 400, 600 }, { 550, 700, 900, 200, 100 } };
            Console.WriteLine(points[1,2] + points[0,3]); // 1300
        }
        public void Question26() // pg 397
        {
            string sValue = "Today is the first day of your life.";
            // a. Create a new string that has all lowercase characters the word Day. Day should be all uppercase. 
            string aString = (sValue.ToLower()).Replace(" day", " DAY");
            Console.WriteLine(aString);
            // b. Create a new string array that contains the eight elements. Each word from the sValue string should be in a sperate array cell.
            string[] bArray = sValue.Split(' ');
            for (int i = 0; i < bArray.Length; i++)
                Console.Write(bArray[i] + " ");
            Console.WriteLine();
            // c. Remove the period from the last array element created in step b. Display the contents of the new array verifying its removal. 
            for (int i = 0; i < bArray.Length; i++)
            {
                bArray[i] = bArray[i].Replace(".", "");
                Console.Write(bArray[i] + " ");
            }
            Console.WriteLine();
            // d. Surround the sValue string with three asterisks on each end.
            Console.WriteLine((sValue.PadLeft(sValue.Length + 3, '*')).PadRight(sValue.Length + 6, '*'));
            // e. Replace the word first with the word best in the sValue string. 
            Console.WriteLine(sValue.Replace("first", "best"));
        }
        public void Question27() // Predict what the results will be by reading the code. pg 397
        { 
            int[] anArray = { 34, 55, 67, 89, 99 };
            // a
            Console.WriteLine(anArray.Length); // 5
            // b
            Console.WriteLine(anArray[2]); // 67
            // c
            Console.WriteLine(anArray[anArray.Length - 2]); // 89
            // d
            Console.WriteLine(anArray[2 + 1] * anArray[0]); // 89 * 34 = 3026
            // e
            Console.WriteLine(anArray.Rank); // 1
        }
    }
}
