// Inline Commment

/*
 * Multiline Comment
 */

/// XML Comment

using System; // this provides access to 2000+ classes called the Framework Class Library (FCL)
              // The "using" keyword is like importing libraries in Java. 

namespace MyFirstApplication 
    /* 
     * The namespace is a way to distinguish between classes of the same name, but with different function. 
     * For example, Fireman.Captain and Police.Captain. 
     * Both are captains but the Fireman namespace and the Police namespace are used to distinguish between them. 
     * The namespace for this simple program could have been ommitted without causing any errors. 
     * The additional namespace umbrella is mainly useful when developing unique code. 
     */
{
    class Chapter2
        /*
         * The class declaration is the foundation of Object Oriented Programming.
         * While a single .cs file can contain multiple class definitions it is 
         * convention to have only a single class definition per file. (same as Java)
         */
    {
        // readonly double five = 5;

        public static void PracticingWritingToConsole()
        {
            /*
             * The area between the brackets here is the definition of the method. 
             */
            Console.WriteLine("Chapter 2");
            Console.WriteLine("Hello World! This is my first C# program.");
            Console.WriteLine("\tProgramming can be \n\tFUN!");
            Console.Write("Hello");
            Console.Write(" there.\n");
            //Console.WriteLine(Program.five);
        }
    }
}
/*
 * Chapter 2 Review
 * 1. C# is mainly used to create web, windows, and console applications.
 * 2. Web pages are created using web forms in the ASP.NET technology. 
 * 3. Windows applications can only be run on windows machines (single platform technology).
 * 4. Console applications are the easiest to create. 
 * 5. C# programs usually begin with a "using" directive (similar to an import statement), 
 *    then there is an optional namespace grouping, and the required class definition. 
 * 6. All C# programs must define a class. 
 * 7. The compiler ignores comments. 
 * 8. Inline comments end with the specific line they inhabit. 
 * 9. Over 2000 classes make up the Framework class library (FCL). A class contains data members
 *    and methods or behaviors that can be reused. 
 * 10. The using-namespace-directive imports all the types contained in the specified namespace. 
 *     Specifying namespace can save a lot of typing, namespace.class would otherwise need to be used for everything. 
 * 11. Everything in C# is designed around a class. Every program must have atleast one class. 
 * 12. A method is a collection of one or more statements taken together that perform an action. 
 * 13. The Main() method is the entry point for every C# console application. It is the genesis of program execution. 
 * 14. The keyword static indicates that a single copy of the method is created. 
 * 15. The keyword void means that the method body returns no value. 
 * 16. WriteLine() is used to write a message to the console. (C# version of System.out.println())
 * 17. Methods communicate with each other through arguments placed inside parentheses. 
 * 18. Readability is important in any language. Make sure the code is easy to read. 
 * 19. The source code must be compiled. 
 * 20. VS IED is an interative development environment. It enables the typing of code, compilation, and execution without leaving the IDE program. 
 * 21. One way to to document desired output is to construct a prototype, or mock-up, of output. 
 * 22. The Read() method accepts any character from a standard input device. IT does nothing with the input. 
 */