using System;
using System.Collections.Generic;
using System.Text;
/*
 * Chapter 11 - Debugging and Handling Exceptions
 * - Learn about exceptions, how they are thrown and caught.
 * - Gain an understanding of the different types of errors that are found in programs. 
 * - Look at debugging methods available in Visual Studio.
 * - Discover how the Debugger can be used to find runtime errrors.
 * - Become aware of and use exception-handling techniques: try, catch, finally clauses.
 * - Explore exception classes and learn how to write and order multple catch clauses.
 * 
 * There are two main types of errors. Compiler/syntax-errors and runtime errors. Compiler errors
 * are easy to catch, but runtime errors are difficut to catch becuase they are logic related. 
 * 
 * To find runtime errors it can be necessary to do some debugging. Debugging is a methodical 
 * process of finding and reducing bugs or defects in a computer program. Most IDEs have fairly
 * sophisticated debugging tools available. 
 * 
 * Breakpoints are used to hault the program at a specific point so that I can examine what is
 * being stored in intermediate values. pg 653-654
 * 
 * Exceptions are unexpected conditions that happen. 
 * Bugs are generally accepted to be problems that were created by the programmer, or "programmer mistakes".
 */

/* pg 665
 *                  -- Exception Handling --
 * The syntax for exception handling is this:
 * 
 * try 
 * {
 * ----- Statements to be tried.
 * } 
 * catch [(ExceptionClassName exceptionIdentifier)]
 * {
 * ----- Statements to do if an exception is thrown. 
 * }
 * catch .... There can be additional catch clauses.
 * [finally
 * {
 * ----- Statements that will always be executed. 
 * }]
 * 
 * It looks a functions like it does in Java.
 */

namespace C_sharp_Programming
{
    class Chapter11
    {
        public static void ExceptionApp_Example11_2() // Example 11-2, pg 666-667
        {
            int[] examScore;
            int totalScores = 0;
            int countOfScores = 0;
            string inValue;
            double averageTestScore;
            try
            {
                Console.Write("How many scores will you enter? ");
                inValue = Console.ReadLine();
                countOfScores = int.Parse(inValue);
                examScore = new int[countOfScores];

                for (int i = 0; i < countOfScores; i++)
                {
                    Console.Write("Enter score {0}:", i + 1);
                    inValue = Console.ReadLine();
                    examScore[i] = int.Parse(inValue);
                    totalScores += examScore[i];
                }
                averageTestScore = totalScores / countOfScores;
                Console.WriteLine("Average is {0}", averageTestScore);
            }
            catch // This catches every exception, which really isn't a good idea. 
            {
                Console.WriteLine("Problem with scores - Cannot compute average.");
            }
            finally
            {
                Console.WriteLine("End of program.");
            }
        }
        public static void ExceptionApp_Example11_4() // Example 11-4, pg 669
        {
            int[] examScore;
            int totalScores = 0;
            int countOfScores = 0;
            string inValue;
            double averageTestScore;
            try
            {
                Console.Write("How many scores will you enter? ");
                inValue = Console.ReadLine();
                countOfScores = int.Parse(inValue);
                examScore = new int[countOfScores];

                for (int i = 0; i < countOfScores; i++)
                {
                    Console.Write("Enter score {0}:", i + 1);
                    inValue = Console.ReadLine();
                    examScore[i] = int.Parse(inValue);
                    totalScores += examScore[i];
                }
                averageTestScore = totalScores / countOfScores;
                Console.WriteLine("Average is {0}", averageTestScore);
            }
            catch (System.Exception e) /* 
                                        * This catches the base Exception. 
                                        * This is better than not catching a specific exception, 
                                        * but it would be best to catch specific exceptions. 
                                        */
            {
                Console.Error.WriteLine("Problem with scores - Cannot compute average.");
                Console.Error.WriteLine(e.Message); // It prints out a useful message. 
            }
            finally
            {
                Console.WriteLine("End of program.");
            }
        }
        public static void ExceptionApp_Example11_5() // Example 11-5, pg 673-674
        {
            int[] examScore;
            int totalScores = 0;
            int countOfScores = 0;
            string inValue;
            double averageTestScore;
            try
            {
                Console.Write("How many scores will you enter? ");
                inValue = Console.ReadLine();
                countOfScores = int.Parse(inValue);
                examScore = new int[countOfScores];

                for (int i = 0; i < countOfScores; i++)
                {
                    Console.Write("Enter score {0}:", i + 1);
                    inValue = Console.ReadLine();
                    examScore[i] = int.Parse(inValue);
                    totalScores += examScore[i];
                }
                averageTestScore = totalScores / countOfScores;
                Console.WriteLine("Average is {0}", averageTestScore);
            }
            catch (System.FormatException fe) // If the input is not a number.
            {
                Console.Error.WriteLine("Exception Type: {0}", fe.Message);
            }
            catch (System.DivideByZeroException dbze) // If the countOfScores is 0.
            {
                Console.Error.WriteLine("Exception Type: {0}", dbze.Message);
            }
            catch (System.ArithmeticException ae) // If an arithmetic operation fails. 
            {
                Console.Error.WriteLine("Exception Type: {0}", ae.Message);
            }
            catch (System.Exception e) // The base exception. 
            {
                Console.Error.WriteLine("Exception Type: {0}", e.Message);
            }
            /*
             * Just like Java, exception handling goes from most specific to most general. 
             * If the first exception that is caught is System.Exception, then there is
             * no point in catching other exceptions, because the base Exception would be
             * caught every time an exception is thrown. The more specific exceptions would
             * never be caught. They would be unreachable code. 
             */
            finally
            {
                Console.WriteLine("End of program.");
            }
        }
    }
    /*
     * Custom exceptions can be created. 
     */
    public class CustomException : System.ApplicationException // Example 11-6, pg 677
    {
        public CustomException(string exceptionType) : base(exceptionType)
        {
            // 
        }
    }
    public class CustomExceptionExample // Example 11-7, pg 678
    {
        public static void RunExample()
        {
            double value1 = 0, value2 = 0, answer;

            try
            {
                answer = GetResults(value1, value2);
            }
            catch (CustomException ce)
            {
                Console.Error.WriteLine(ce.Message);
            }
            catch (System.Exception e)
            {
                Console.Error.WriteLine("Something else happened: {0}", e.Message);
            }
        }
        /*
         * This is an example of how to use a customer exception. The exception must be created
         * and thrown. 
         */
        public static double GetResults(double value1, double value2)
        {
            if (value2 < 0.000001) // Comparing floating point values is dumb, but its the example. 
            {
                CustomException customExc = new CustomException("Exception type: Floating-point division by zero.");
                throw customExc; // The exception is thrown. 
            }
            return value1 / value2;
        }
    }
    
}
