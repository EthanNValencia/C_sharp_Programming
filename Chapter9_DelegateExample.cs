using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Programming
{
    delegate string ReturnsSimpleString(); // 3 of these delegates are instantiated in the RunDelegateExample().
    class Chapter9_DelegateExample
    {
        public static void RunDelegateExample() // Example 9-5, pg 482-483
        {
            int age = 18;
            ReturnsSimpleString saying1 = new ReturnsSimpleString(AHeading); // This uses AHeading()
            ReturnsSimpleString saying2 = new ReturnsSimpleString((age + 10).ToString); // This simply returns the string provided.
            ReturnsSimpleString saying3 = new ReturnsSimpleString(EndStatement); // This uses EndStatement()
            Console.WriteLine(saying1() + saying2() + saying3());
            /*
             * The delegates are used like objects. 
             * The power of delegates is that the same delegate can can call different methods during run time. 
             * When the program is compiled, the method of methods that will be called are not determined. 
             * This is why delegates work so well in an event-driven arena, when you do not know which
             * event will occur first. 
             */
        }

        static string AHeading()
        {
            return "Your age will be ";
        }

        static string EndStatement()
        {
            return " in 10 years.";
        }
    }
}
