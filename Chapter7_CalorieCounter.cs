using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Programming
{
    class Chapter7_CalorieCounter // Example 7-17, pg 370
    {
        public static void run()
        {
            int[,,] calories = { { {900,750,1020,0},
                                   {300,1000,2700,0},
                                   {500,700,2100,0},
                                   {400,900,1500,0},
                                   {400,800,1700,0},
                                   {400,700,1200,0} },

                                 { {850,1900,1200,0},
                                   {900,2500,950,0},
                                   {500,500,850,0},
                                   {700,300,500,0},
                                   {400,500,500,0},
                                   {350,850,850,0} },

                                 { {850,1900,1200,0},
                                   {900,2500,950,0},
                                   {500,500,850,0},
                                   {700,300,500,0},
                                   {400,500,500,0},
                                   {350,850,850,0} },

                                 { {850,1900,1200,0},
                                   {900,2500,950,0},
                                   {500,500,850,0},
                                   {700,300,500,0},
                                   {400,500,500,0},
                                   {350,850,850,0} } };
            AccumulateCalories(calories);
            DisplayTotals(calories);
        }
        public static void AccumulateCalories(int[,,] calories)
        {
            for (int week = 0; week < calories.GetLength(0); week++)
                for (int day = 0; day < calories.GetLength(1); day++)
                    for (int m1 = 0; m1 < calories.GetLength(2); m1++)
                        calories[week, day, 3] += calories[week, day, m1];
        }
        public static void DisplayTotals(int[,,] calories)
        {
            string[] dayName = { "Sun", "Mon", "Tue", "Wed", "Thr", "Fri", "Sat" };

            Console.WriteLine("Week#\tDay#\tTotalCalories#\t");
            for (int week = 0; week < calories.GetLength(0); week++)
                for (int day = 0; day < calories.GetLength(1); day++)
                    Console.WriteLine("{0}\t{1}\t{2}", week + 1, dayName[day], calories[week, day, 3]);
        }
    }
}
