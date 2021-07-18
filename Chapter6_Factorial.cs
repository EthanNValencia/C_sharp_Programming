using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Programming
{
    class Chapter6_Factorial
    {
        public void runFactorial()
        {
            int result;
            string moreData;
            int n;
            string equation = "";
            DisplayInformation();

            do
            {
                n = InputN();
                CalculateNFactorial(n, out result, out equation);
                DisplayNFactorial(n, result, equation);
                moreData = PromptForMoreCalculations();
            }
            while (moreData == "y");
        }

        public void DisplayInformation()
        {
            Console.WriteLine("n! represents the product of the first n integers.");
        }

        public void CalculateNFactorial(int n, out int result, out string equation)
        {
            result = 1;
            equation = "";
            for(int i = n; i > 0; i--) // This loop counts down to zero. 
            {
                result *= i;
                if (i == 1)
                {
                    equation += i;
                } 
                else
                {
                    equation += i + "x";
                }
            }
        }

        public int InputN()
        {
            string inValue;
            int n;
            Console.WriteLine("\nEnter the number to use to compute n! ");
            inValue = Console.ReadLine();
            n = Convert.ToInt32(inValue);
            return n;
        }
        public void DisplayNFactorial(int n, int result, string equation)
        {
            Console.WriteLine("{0}! is {1}", n, result);
            Console.WriteLine(equation + " = " + result);
        }

        public string PromptForMoreCalculations()
        {
            string moreData;
            Console.WriteLine("\nDo you want to calculate another factorial?\n" +
                              "Enter y for another calculation.\nAny other character to stop.");
            moreData = Console.ReadLine();
            return moreData;
        }
    }
}
