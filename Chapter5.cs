using System;
using System.Collections.Generic;
using System.Text;


/*
 * Chapter 5 - Making Decisions - Overview - Pg 209
 * Learn about conditional expressions. Examine conditional opertors. 
 * Learn about if statements in C#.
 * Learn about switch statements. 
 * Learn about ternary operators. 
 * Review order of operation. 
 */


/*
 * Review - Programming Constructs - Pg 210
 * There are three categories of programming constructs: simple sequence, select statement, and iteration. 
 * Simple Sequence - This is when a program has a single flow from top to bottom. This can include method calls, 
 * but the thread is ultimately returned to the same place. 
 * Select Statement - This is when the flow of order is interupted by a decision making block. The decision block
 * allows for the flow to be deviated from. 
 * Iteration - This is about looping or executing the same block of code multiple times in order to achieve something. 
 */

namespace C_sharp_Programming
{
    class Chapter5
    {
        public void gradePointAverage() // Example 5 - 1, pg 210
        {

            Double gradePointAverage = 3.90;
            String awardType = "No Awards";
           
            if (gradePointAverage > 3.80) // This is a basic if check statement. A decision was made here. 
            {
                awardType = "Deans List";
            }
            Console.WriteLine("For a GPA of {0} there is an award of {1}", gradePointAverage, awardType);

            Char letterGrade = 'F';

            if (letterGrade == 'F')
            {
                Console.WriteLine("You must repeat the course, because the letter grade is F."); 
            }

            int examScore = 49;

            if (examScore < 50)
            {
                Console.WriteLine("Your exam score was less than 50. You must do better.");
            }

        }
    }
}
