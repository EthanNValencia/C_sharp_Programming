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
            int counter = 0;
            while(counter < 11)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", counter, Math.Pow(counter, 2), Math.Pow(counter, 3), Math.Pow(counter, 4), Math.Pow(counter, 5));
                counter++;
            }
        }

    }
}
