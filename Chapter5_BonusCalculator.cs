using System;
using System.Collections.Generic;
using System.Text;

/*
 * pg 224
 * Allow the user to input their gross sales for the year. This value
 * is checked to determine if they deserve a bonus. 
 * A bonus is granted if they have a gross sales of $500,000.00 or more. 
 * 
 */

namespace C_sharp_Programming
{
    class Chapter5_BonusCalculator
    {
        public void CheckBonus()
        {
            decimal bonus = 0m;
            Console.Write("What was your gross sales? ");
            string input = Console.ReadLine();
            if(Decimal.Parse(input) > 499999.99m)
            {
                Console.WriteLine("Congrats you earned the bonus!");
                bonus = 1000m;
            } else if (Decimal.Parse(input) < 499999.99m)
            {
                Console.WriteLine("You did not earn the bonus this year.");
            }
            Console.WriteLine("Your bonus is: {0:C}", bonus);
        }
    }
}
