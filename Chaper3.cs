using System;
/*
 * This chapter is mostly about data types and expressions. 
 */

namespace MyFirstApplication
{
    class Chaper3
    {
        // numeric data types
        byte bt = 255; // bytes range from 0 to 255
        sbyte sbt = 127; // sbytes range from -128 to 127
        char ch = 'a'; // characters
        int num = 2147483647; // int ranges from -2147483647 to 2147483647
        uint unum = 4294967295; // uint ranges from 0 to 4294967295
        long lg = 9223372036854775807; // long ranges from -9223372036854775808 to 9223372036854775807
        ulong ulg = 18446744073709551615; // ulong ranges from 0 to 18446744073709551615
        short sht = 32767; // short ranges from -32768 to 32767
        ushort usht = 65535; // ushort ranges from 0 to 65535

        // string
        string name = "Ethan \nNephew";
        string sentence = "This is a sentence.";

        // declaring constants
        const int CONST_INT = 24;
        const string CURRENCY_US = "USD";


        public static void PracticingAddition()
        {
            int i = 4 + 3;
            Console.WriteLine("Chapter 3");
            /*
            Console.WriteLine(i++); // I is printed, but then it is incremented. 
            Console.WriteLine(i);
            Console.WriteLine(++i);
            */
            char b = 'a';
            Console.WriteLine(b); 
            b++;
            Console.WriteLine(b);
            Console.WriteLine(++b);

            int num = 100;
            Console.WriteLine(num++); // Displays 100, then 100 is incremented to 101.
            Console.WriteLine(num);   // Displays 101.
            Console.WriteLine(++num); // Preincrements to 102, then it displays 102. 
            Console.WriteLine(num++ + " " + ++num); // Displays 102, then adds 1, then adds 1, then displays 104. 

            int count = 0, result = 0, firstNum = 10;
            count++; // count is 1
            result = count++ * --firstNum + 100; // 1 * 9 + 100 == 109 (???)
                                                 // The count++ increment is ignored in the equation because of its placement.
                                                 // However, count is still incremented to 2. 
                                                 // A different equation that behaves more straight forward is below, 
                                                 // ++count * --firstNum + 100 == 2 * 9 + 100 == 118
            Console.WriteLine("count++ * --firstNum + 100 == " + result);
            Console.WriteLine("Count is " + count + " firstNum is " + firstNum + " result is " + result);

            /*
             * I like to stay away from compound operations, because they can be a little confusing. 
             * It is easy to forget that the compound operation is executed last, even if the operation
             * takes a PEMDAS lead. 
             */
            int total = 2;
            total *= 4 / 2 + 4; // ((4/2) + 4) * 2 == 12
                                // Even though the compound operation is multiplication,
                                // it is executed last. Compound operations are always
                                // the final operation -- regardless of PEMDAS. 
            Console.WriteLine(total);


            // Example 3-13, pg 110
            int answer = 100;
            answer += 50 * 3 / 25 - 4; // 100 + (150 / 25 - 4) == 100 + (6 - 4) == 100 + 2 == 102
            Console.WriteLine("100 += 50 * 3 / 25 - 4 == " + answer);
            moreMixedExpressions();
        }
        public static void moreMixedExpressions()
        {
            // Example 3-14, pg 112
            double answer;
            answer = 10 / 3; // answer is 3, not 3.33 (because integer division took place)
            Console.WriteLine(answer);
            // Example 3-15, pg 112
            int value1 = 440,
                anotherNumber = 70;
            double value2 = 100.60,
                   anotherDouble = 100.999;
            value1 = (int) value2; // A double cannot be assigned to an int without casting. 
            value2 = anotherNumber; // A double be assigned to an integer without casting. 

            // Example 3-16, pg 113
            int exam1 = 86,
                exam2 = 92,
                exam3 = 91;
            double examAverage;
            examAverage = (exam1 + exam2 + exam3) / 3;
            Console.WriteLine("\n(exam1 + exam2 + exam3) / 3 is " + examAverage);
            examAverage = (exam1 + exam2 + exam3) / 3.0;
            Console.WriteLine("(exam1 + exam2 + exam3) / 3.0 is " + examAverage);
            examAverage = (exam1 + exam2 + exam3) / (double) 3;
            Console.WriteLine("(exam1 + exam2 + exam3) / (double) 3 is " + examAverage);

            // Example 3-18, pg 114
            double price = 1089.30;
            Console.WriteLine("\nC# can display a double as a currency.");
            Console.WriteLine("The price is {0:C}.", price);
        }
    }
}
