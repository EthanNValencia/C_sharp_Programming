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
 */

namespace C_sharp_Programming
{
    class Chapter11
    {
    }
}
