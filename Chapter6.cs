using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace C_sharp_Programming
{
    class Chapter6
    {
        public void testWindow() // Chapter 6, example 6-5, pg 274-275
        {
            int counter = 0;
            string result = "";
            while(counter < 10)
            {
                counter++;
                result += "\t"
                       + counter
                       + "\t"
                       + Math.Pow(counter, 2)
                       + "\n";
            }
            System.Windows.Forms.MessageBox.Show(result, "1 through 10 and their squares."); // This doesn't work and the textbook is out dated. 
        }

    }
}
