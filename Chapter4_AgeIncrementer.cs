using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Programming
{
    class Chapter4_AgeIncrementer
    {
        public static void IncrementAge()
        {
            int age;
            string aValue;
            Console.WriteLine("Enter your age: ");
            aValue = Console.ReadLine();
            age = int.Parse(aValue);
            Console.WriteLine("Your age next year will be: {0}", ++age);
        }
    }
}
