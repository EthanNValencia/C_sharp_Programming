using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

/*
 * CHAPTER 6
 * 
 * Learn about loops in C#.
 * Learn about counter, state, and sentinel controlled loops. 
 * Recursion.
 * Introduced to foreach looping structures.
 * Learn about continue and break in loops.
 * Loops should have one entry point and one exit point. This convention makes the loop testable and debuggable. 
 * 
 * Pretest loop vs Posttest loop
 * A pretest loop checks the test conditions prior to running: for and while are pretest loops.
 * A posttest loop checks the test conditions after running: do...while is a posttest loop.
 * 
 * If you intend to place a block of statements within a loop body, you must use curly braces around the block.
 * 
 */

namespace C_sharp_Programming
{
    class Chapter6
    {
        public void WhileLoopExample610() // Chapter 6, example 6-10, pg 286
        {
            /*
             * These are different types of loops that produce the same results. 
             */

            int counter = 0;
            while(counter < 11)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", counter, Math.Pow(counter, 2), Math.Pow(counter, 3), Math.Pow(counter, 4), Math.Pow(counter, 5));
                counter++;
            }
            Console.WriteLine("\n");

            for(int i = 0; i < 11; i++)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", i, Math.Pow(i, 2), Math.Pow(i, 3), Math.Pow(i, 4), Math.Pow(i, 5));
            }
            Console.WriteLine("\n");
        }
        public void ForLoopExamples() // Pg 290, examples
        {
            for (double d = 15.0; d < 20.0; d += 0.5)
            {
                Console.Write(d + "  ");
            }
            Console.WriteLine("\n");
            for (double d = 15.0; d < 20.0; d += 0.5)
            {
                Console.Write(d + "  ");
                d += 2.0; // Modifying the counter within the loop.
            }
            Console.WriteLine("\n");
            double endValue = 20; // The endvalue must be assigned to a number that will cause the loop to run to begin with. 
            for (double d = 15.0; d < endValue; d += 0.5)
            {
                Console.Write(d + "  ");
                d += 2.0;
                endValue = 30; // Assigning the end value within the loop. This is really inefficient. 
            }
            Console.WriteLine("\n");
        }

        public void ForEachExample612() // Example 6-12, pg 292
        {
            /*
             * This is similar to the Java enhanced for loop. 
             */
            int[] number = { 2, 3, 4, 1, 2, 10 };
            foreach(int val in number) // For each value in the number array, execute the line below. 
            {
                Console.Write(val + " ");
            }
            Console.WriteLine("\n");
        }

        public void DoWhileLoop()
        {
            /*
             * Like Java, do while loops are useful for when it is desirable for a loop to run
             * at least once, regardless of the test condition. The loop runs first, then the 
             * test condition is assessed. 
             */
            int counter = 5;
            do
            {
                Console.WriteLine(counter + " squared is " + Math.Pow(counter, 2));
                counter--;
            }
            while (counter > 0);
            Console.WriteLine("\n");
        }

        public void NestedLoopExample() // Example 6-14, pg 295
        {
            int inner;
            for (int outer = 0; outer < 2; outer++)
            {
                for(inner = 10; inner > 5; inner--)
                {
                    Console.WriteLine("Outer: {0}  Inner: {1}", outer, inner);
                }
            }
            Console.WriteLine("\n");
        }

        public int Fac(int n) // Example 6-16, pg 300
        /* 
         * Visually, recursive functions look kind of like a V, they go from the top, to the bottom, then back up to the top. 
         * This is a recursive example that determines the factorial of a given int. 
         * While recursive functions are shorter to write, they take up lots of unnecessary resources. 
         * Like Java, recursion is largely a relic, that should be utilized if the depth of the call stack
         * is fairly short. 
         */
        {
            if (n == 1)
                return 1;
            else
                return (n * Fac(n - 1));
            /*
             * How does this method work? 
             * 
             * Fac(4) -> Fac(3) -> Fac(2) -> Fac(1) -> 
             * The bottom is reached 
             * Fac(1) returns 1 ->
             * Fac(2) returns n * Fact(1) or 2 * 1 -> 
             * Fac(3) returns n * Fact(2) or 3 * 2 -> 
             * Fac(4) returns n * Fact(3) or 4 * 6 -> 
             * The top is reached
             * Final result is 24
             */
        }

        public void BreakExample() // Example 6-17, pg 303
        {
            int total = 0;
            for (int nValue = 0; nValue < 10; nValue++)
            {
                if (nValue == 5)
                {
                    break;
                }
                total += nValue; // What happens here?
                /* 
                 * 0 += 0 = 0
                 * 0 += 1 = 1
                 * 1 += 2 = 3
                 * 3 += 3 = 6
                 * 6 += 4 = 10
                 * ~ break ~
                 * total is 10
                 */
                Console.Write(nValue + " ");
            }
            Console.WriteLine("\nTotal is equal to {0}\n", total);
        }

        public void ContinueExample()
        {
            int total = 0;
            for (int nValue = 0; nValue < 10; nValue++)
            {
                if (nValue % 2 == 0)
                {
                    continue; // If nValue is even, then the control flow will be returned to the loop heading. 
                }
                total += nValue;             // If nValue % 2 == 0, this will not be reached. 
                Console.Write(nValue + " "); // If nValue % 2 == 0, this will not be reached.
            }
            Console.WriteLine("\nTotal is equal to {0}\n", total); // The final total is 25
            /*
             * 1 + 3 + 5 + 7 + 9 = 25
             */
        }

        public void MultipleChoiceQuestions() // pg 319 - 325
        {
            int counter = 0;
            int num = 10;
            while (num > 0)
            {
                num--;
                counter++;
            }
            Console.Write(counter + " ");

            counter = 0;
            for (num = 0; num < 10; num++)
                counter++;
            Console.Write(counter + "\n");

            num = 1;
            do
            {
                num++;
                Console.WriteLine(num++);
            } while (num < 3);

            int aValue = 0, n = 10;
            for (int i = n; i > 0; i--) // i is 10, the for loop runs prior to decrementing, therefor 10 is pushed through first. 
                if (i % 2 == 0) // if i is even
                    aValue = aValue + i; // add i to the sum
            Console.WriteLine("\n" + aValue + "\n"); // 10+8+6+4+2 = 30


            // produce: 2 4 6 8 10
            n = 0; // Question 10, pg 321
            do
            {
                n = n + 2;
                Console.Write("{0} ", n);
            } while (n < 10); // When n is 10, this stops. 

            Console.WriteLine("\n");

            int test = 0; // Question 12, pg 322, what would the output be?
            while (test < 0) // The test condition fails. 
            {
                Console.Write("{0} ", test); // Never executed. 
                test++; // Never executed. 
            }
            Console.Write("{0}", test); // 0 is printed. 
        }

        public void Question20()
        {
            int i = 0;
            while (i < 10);
            i++;
            Console.Write(i);
        }

        /*
         * Produce a for and while loop that do what the first do...while loop does. 
         */
        public void Question21()
        {
            int counter = 100;
            do { // make this loop as a for and while
                Console.Write(counter + " ");
                counter--;
            } while (counter > 0);

            Console.WriteLine("\n");

            for (int i = 100; i > 0; i--) // for 
                Console.Write(i + " ");

            Console.WriteLine("\n");
            
            counter = 100;
            while (counter > 0) // while
            {
                Console.Write(counter + " ");
                counter--;
            }
        }

        /*
         * Write a for loop to display every third number beginning with 10 through 100.
         */
        public void Question22()
        {
            for (int i = 10; i <= 100; i += 3)
                Console.Write(i + " ");
        }


    }
}
