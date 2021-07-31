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

/*
 * Specifying pathname can be frustrating at times. In order to specify a path to the current
 * level: "..\..\filename" 
 * The "..\" means that the index is being pulled back a folder level. 
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
                Console.WriteLine("Attributes: {0}", File.GetAttributes(fileName)); // Attributes are enumeration (example below)
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
        /*
         * Directory Class - useful methods include: // pg 712-713
         * 
         * - CreateDirectory()
         * - Delete()
         * - Exists()
         * - GetCreationTime()
         * - GetCurrentDirectory()
         * - GetDirectories()
         * - GetFiles()
         * - GetParent()
         * - GetLastWriteTime()
         * - Move()
         * - SetCurrentDirectory()
         */

        /*
         * Useful distinction
         * DirectoryInfo and FileInfo are classes that can be instantiated.
         * File and Directory are static classes that cannot be instantiated. 
         */

        /*
         * FileInfo Class Properties: // pg 713-714
         * - Attributes
         * - Directory
         * - DirectoryName
         * - Exists
         * - Extension
         * - FullName
         * - LastAccessTime
         * - LastWriteTime
         * - Length
         * - Name
         */
        public static void Example_12_2() // Example 12-2, pg 714
        {
            /*
             * This method goes through all the files that are in the directory
             * and prints out some basic information about them to the console. 
             */
            DirectoryInfo dir = new DirectoryInfo(".");
            Console.WriteLine("Current Directory: \n{0}\n", Directory.GetCurrentDirectory());
            Console.WriteLine("FileName".PadRight(59) + "Size".PadRight(11) + "Creation Time");
            foreach (FileInfo fil in dir.GetFiles("*.*"))
            {
                string name = fil.Name;
                long size = fil.Length;
                DateTime creationTime = fil.CreationTime;
                Console.WriteLine("{0} {1,12:N0}{2,20:g}", name.PadRight(50), size, creationTime);
            }
        }
        /*
         *              ---- StreamWriter & StreamReader ----
         * 
         * Useful StreamWriter members:
         * - AutoFlush - gets or sets value indicating whether the STreamWRiter flushes its buffer. 
         * - Close() 
         * - Dispose() - Releases unmanaged resources used by the StreamWriter.
         * - Flush() - Clears all buffers and causes any buffered data to be written to the underlying stream.
         * - NewLine - gets or sets the terminatitor string.
         * - Write()
         * - WriteLine()
         * 
         * StreamWriter Overloaded Constructor Example:
         * new StreamWriter("..\..\info.txt, true); 
         * The true indicates that the txt file can be appended. 
         * 
         * Useful StreamReader members:
         * - Close()
         * - DiscloseBufferedData() - Allows the StreamReader to discard its current data.
         * - Peek() - Returns the next available character, but does not consume it.
         * - Read()
         * - ReadBlock() - Reads a specific number of characters and writes data to buffer beginning at the index. 
         * - ReadLine()
         * - ReadToEnd() - Reads from current position to the end.
         */
        public static void ConstructStreamObjects()
        {
            StreamWriter outputFile = new StreamWriter("filename"); // writes to file
            StreamReader inputFile = new StreamReader("filename"); // reads from file
        }
        /*
         * Be sure to close all files before the application exits. This ensures that the data
         * is usable for the next application. 
         */


    }
}
