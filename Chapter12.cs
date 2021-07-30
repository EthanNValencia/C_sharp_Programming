using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
/*
 *              -- Chapter 12 Working with Files -- pg 705
 * - Learn about the System.IO namespace
 * - Explore the FIle and Directory classes
 * - Constrast the FileInfo and DirectoryInfo classes to the File and Directory classes
 * - Discover how stream classes are used
 * - Read data from text files
 * - Write data to text files
 * - Explore appending data to text files
 * - Use exception-handling techniques to process text files
 * - Read from and write to binary files
 * 
 * Object > MashalByRefObject // pg 708
 * A subclass of Object is the MarshalByRefObject. This is the base class for objects that
 * communicate across application domain boundaries by exchanging messages using a proxy. 
 * 
 * Objects that do not inherit from MarshalByRef are implicitly marshal by value. // pg 708 
 * 
 * FileInfo and DirectoryInfo extend the FileSystemInfo class. 
 * StreamReader extends the TextReader class.
 * StreamWriter extends the TextWriter class. 
 */

 /* 
 * The IO.File class provides static methods that aid in copying, moving, renaming, creating, 
 * opening, deleting, and appending to files. Useful classes include:
 * - AppendAllText()
 * - AppendText()
 * - Copy(string sourceFile, string targetFile)
 * - Create()
 * - Delete()
 * - Exists()
 * - GetCreationTime()
 * - GetLastAccessTime()
 * - GetLastWriteTime()
 * - Move()
 * All of the IO.File classes tend to do exactly what they say they do. 
 */
namespace C_sharp_Programming
{
    class Chapter12
    {
        public static void Example_12_1() // Example 12-1, pg 710-711
        {
            string fileName = $@"Example.bmp"; // The file must bed placed in: C_sharp_Programming\bin\Debug\netcoreapp3.1
            string path = Path.Combine(Environment.CurrentDirectory, fileName); // This shows where the file should be located.
            if (File.Exists(fileName))
            {
                Console.WriteLine("Filename: {0}", fileName);
                Console.WriteLine("Filepath: {0}", path);
                Console.WriteLine("Attributes: {0}", File.GetAttributes(fileName));
                Console.WriteLine("Created: {0}", File.GetCreationTime(fileName));
                Console.WriteLine("Last Accessed: {0}", File.GetLastAccessTime(fileName));
            }
            else
            {
                Console.WriteLine("{0} not found - using current directory", fileName);
            }
        }
        /*
         * This is an example of a programmer defined enumeration. // pg 711
         */
        public enum WeekDay
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Firday,
            Saturday
        }
        public static void EnumerationExample()
        {
            Console.WriteLine("\nEnumeration Example");
            Console.WriteLine("Today is {0}.", WeekDay.Tuesday);
            Console.WriteLine("{0} = {1}.", WeekDay.Sunday, (int)WeekDay.Sunday);
            Console.WriteLine("{0} = {1}.", WeekDay.Tuesday, (int)WeekDay.Tuesday);
        }
    }
}
