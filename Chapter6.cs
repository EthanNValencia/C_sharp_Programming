using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

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
    }
}
