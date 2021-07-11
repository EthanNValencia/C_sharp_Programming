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
            /*
             * In a conditional statement there are three basic requires: Operand - Operator - Operand
             * Ex: 4 < 5 
             * The 4 and 5 are the operands. 
             * This is the same as an arithmetic expression, so it is easy to remember. 
             * Devising a conditional statement is simply. Simple guide is to ask, 
             * what is being compared (operand)? How are they being compared (operator)? 
             */
            Console.WriteLine("25 == Math.Pow(5,2) is evaluated to {0}", 25 == Math.Pow(5,2));
            /*
             * Convention pg 213
             * When comparing two values, if one operand is a literal and one is a variable, then
             * it is convetion to place the variable as the first operand. 
             * Ex: thisIsAVariable < 25
             */
            double aValue = 10.0 / 3.0;
            Console.WriteLine("{0} == {1} evaluates to {2}", aValue, 3.33333333, aValue == 3.33333333);
            /*
             * The above two lines demonstrates how using doubles and floats in equality statements should
             * probably be avoided. Floating point and double division does not produce a finite number. 
             */
            Console.WriteLine("{0} == {1} evaluates to {2}", "cs158", "CS158", "cs158" == "CS158"); // Example 5-2, pg 213
            /*
             * Like Java all characters have a unicode value. 5-2 evaluates to false because C and c both have different
             * unicode values. Once a location if inequality is discovered, the assessment ends, and is determined to 
             * be false. No more comparisons are required. 
             * Unlike Java, strings can simply be compared by using the ==. The above WriteLine would cause an error, 
             * because Java requires the .equals() method call when comparing strings. C# is a little easier in this
             * regard. String operands cannot be comapred using relational operators: <,>,>=,<=
             */

            /*
             * Avoiding difficult to read syntax pg 215
             * (examScore >= 90) and (examScore > 89) are effectively the same, however it could be argued
             * that the first statement is more difficult to read than the second statement. 
             * Personally, I never really thought much about the difficult associated with these two
             * statements, but it is true that the second statement probably is easier to read. 
             */

            // Example 5-4, pg 215
            aValue = 100; // int
            int bValue = 1000;
            char cValue = 'A';
            string vValue = "CS158";
            decimal money = 50.22m;
            double dValue = 50.22;

            /*
             * (money == 100.00) will produce an error, because money is a decimal. Not a double. 
             * decimal cannot be compared with a double
             * decimal cannot be compared with an int
             * int cannot be compared with a string
             */
            Console.WriteLine("{0} == {1} evaluates to {2}", money, 50.22m, money == 50.22m);
            Console.WriteLine("{0} < {1} evaluates to {2}", cValue, 'F', cValue < 'F'); // 'F' has a larger unicode value than 'A'

            /*
             * Logical Operators in C# pg 216-218
             * &, &&, |, ||, and !
             * 
             * AND is &&        OR IS ||
             * 
             * With && both sides of the expression must evaluate to true in order to be true. 
             * With || one side must evaluate to true in order to be true. They conduct short-
             * circuit valuations. This means that once enough information is processed to
             * determine whether the statement is true or false, then evaluation ends at that 
             * point. 
             * 
             * ! is the logical negation operator
             * 
             * !true is false, !false is true
             * 
             * & | conduct the same evaluations, but they do not do short-circuit evaluations. 
             * They evaluate the entire statement. 
             */ 
        }
        public void example56(int examScore) // example 5-6, pg 222
        {
            if (examScore > 89)
            {
                Console.WriteLine("Congrats, your grade is 90 or higher!");
            }
        }

        public void largestValue(int valueOne, int valueTwo)
        {
            int theLargestValue = 0;
            if (valueOne > valueTwo)
            {
                theLargestValue = valueOne;
            } else if (valueOne < valueTwo)
            {
                theLargestValue = valueTwo;
            } 
            

            if (valueOne == valueTwo)
            {
                Console.WriteLine("They are both equal. {0} is equal to {1}.", valueOne, valueTwo);
            } else if (valueOne != valueTwo)
            {
                Console.WriteLine("{0} is the greatest value between {1} and {2}.", theLargestValue, valueOne, valueTwo);
            }
        }
        /*
         * In C# the if-else statements work the same as in Java, so I don't see a big need to
         * go over things that I already know. I'll continue reading and adding when I find something
         * that is different or new. 
         */
    }
}
