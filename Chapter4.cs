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
        public static void MoreMathClassExamples() // Example from pg 158
        {
            /*
             * Note: Variable Scope, pg 162
             * A variable a specific scope in which it can be used. This is the area or space
             * that the variable can be accessed. This method has double aValue. aValue is a method
             * defined scope. It does not exist and cannot be access outside of this method block. 
             * There are many different levels of scopes, just like in Java. A common one is a 
             * class wide scope. This is when a variable is a class variable and it can be used 
             * from anywhere within the specific class it inhabits. 
             */
            double aValue = 78.926;
            double result1, result2;
            result1 = Math.Floor(aValue);
            result2 = Math.Sqrt(aValue);
            Console.WriteLine("aValue rounded to two decimal places is {0}", Math.Round(aValue, 2));
        }

        /*
         * Types of paramerters in C#, pg 183
         * 1. ref
         * 2. out
         * 3. params (discussed in chapter 7 with arrays)
         */

    }
}

/*
 * Quick Review pg 197
 * 1.  Methods are the members of a class that describe the behavior of the data. 
 * 2.  The Main() method is required for both console and Windows applications. 
 * 3.  Main() should include the static keyword. 
 * 4.  The heading to a method can consist of modifiers, a return type, a method
 *     identifier, and parameters. The body of the method is enclosed in curly 
 *     braces. 
 * 5.  When the static modifier is included with a method, it becomes a class method. 
 * 6.  Instances methods require that an object be instantiated before they access 
 *     the method. 
 * 7.  Private members are accesible only within the body of the class in which they
 *     they are declared. 
 * 8.  Often in object-oriented development, data is defined with a private modifier, 
 *     and methods that access the data are declared to have public access. 
 * 9.  The return type identifies what type of value is returned when the method is 
 *     completed. Any of the predefined or valid user-defined types can be returned. 
 * 10. The void keyword specifies that the method does not return a value. 
 * 11. Many programmers employ the standard convention of using an action verb phrase 
 *     to name methods. 
 * 12. Formal parameters appear in the heading of a method. Actual arguments appear 
 *     in the call. The actual arguments are the actual that is sent to the method. 
 * 13. The signature of a method consits of the name of the method, modifers, and 
 *     the types of its formal parameters. It does not include the return type. 
 * 14. Overloaded methods are methods with the same name but a different number or 
 *     type of parameter. 
 * 15. The ReadLine() method returns all characters up to the current end-of-line 
 *     terminator, the Enter key. It returns a string that must be parsed into a 
 *     number before the value can be used in arithmetic. 
 * 16. Variables declared in the Main() method and other methods are considered 
 *     local variables and are visible only inside the body of the method in which 
 *     they are declared. 
 * 17. Constructors are special methods that create instances of a class. Constructors 
 *     do not return a value, but you should not include the keyword void. 
 * 18. Constructors use the same identifier as the class name. The keyword new is an 
 *     operator that calls constructor methods. 
 * 19. Use public access with constructors and most other methods. Use the private access 
 *     modifier with data members. 
 * 20. The default constructor has no body and is automatically created if you do not 
 *     write one. If you write even one constructor, you lose the default constructor 
 *     and have to write it. 
 * 21. Accessors are methods that access the value of a private data member without changing 
 *     it. Accessors are also referred to as getter methods. 
 * 22. Mutators are used to change the current state of object members' data. Mutator methods 
 *     are also referred to as setters.
 * 23. A property looks like a data field and provides a way to set or get private member 
 *     data. You can define the set without the get or vice versa. It is not necessary to 
 *     include both. 
 * 24. If a value is being returned from a method, such as with an expression or output statement, 
 *     there must be a location in which the value can be accepted when the method is finished. 
 *     The call actually may appear anywhere a compatible value of that type can be placed.
 * 25. To call nonvalue-returning methods, simply type the method's name. If it is a static method, 
 *     qualify it with the class name. If it is an instance method, qualify the identitifer with an 
 *     object. If the method has parameters, the call includes actual arguments inside the parentheses, 
 *     without the type. 
 * 26. C# offers both call by value and call by reference. Call by value is the default if no keyword 
 *     is added in the heading. Call by reference is possible through using the ref and out keywords. 
 *     They must appear both in the heading and in the call. ref requires that the argument be initialized 
 *     before it is sent. 
 */
