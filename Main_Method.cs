using MyFirstApplication;
using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Programming
{
    class Main_Method
    {
        static void Main(string[] args)
        {
            // Chapter2.PracticingWritingToConsole();
            // Chaper3.PracticingAddition();

            // new Chapter3_Carpet_Calculator("best" , 27.95); 
            // new Chapter3_Carpet_Calculator("econ", 15.95);

            // Chapter3_Carpet_Calculator carpetCalculator = new Chapter3_Carpet_Calculator("Carpet", 22.95);
            // carpetCalculator.Name = "Changed Name"; // this changed the name variable. This was done without a setter method. Kind of cool!
            // Console.WriteLine(carpetCalculator.ToString());

            // Chapter4.SquareExample();
            // Console.WriteLine("You travled 120 miles with 3 gallons, your MPG is {0:N2}",  Chapter4.CalculateMilesPerGallon(120, 3));
            // Chapter4.PrintExample();
            // Chapter4.CastingCharExample();
            // Chapter4.MoreMathClassExamples();
            // Chapter4.UsingReadInAWriteLine();
            // Chapter4_AgeIncrementer.IncrementAge(); // This scans for an input and increments it by one. 

            Chapter4_CarpetCalculator ccc = new Chapter4_CarpetCalculator(500, 32);
            ccc.SetNoOfSquareYards(40, 12);
            Console.WriteLine(ccc.ToString());
        }
    }


}
