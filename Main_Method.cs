using MyFirstApplication;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace C_sharp_Programming
{
    class Main_Method
    {
        static void Main(string[] args)
        {
            /*
            Chapter2.PracticingWritingToConsole();
            Chapter3.PracticingAddition();

            new Chapter3_Carpet_Calculator("best" , 27.95); 
            new Chapter3_Carpet_Calculator("econ", 15.95);

            Chapter3_Carpet_Calculator carpetCalculator = new Chapter3_Carpet_Calculator("Carpet", 22.95);
            carpetCalculator.Name = "Changed Name"; // this changed the name variable. This was done without a setter method. Kind of cool!
            Console.WriteLine(carpetCalculator.ToString());

            Chapter4.SquareExample();
            Console.WriteLine("You travled 120 miles with 3 gallons, your MPG is {0:N2}",  Chapter4.CalculateMilesPerGallon(120, 3));
            Chapter4.PrintExample();
            Chapter4.CastingCharExample();
            Chapter4.MoreMathClassExamples();
            Chapter4.UsingReadInAWriteLine();
            Chapter4_AgeIncrementer.IncrementAge(); // This scans for an input and increments it by one. 

            Chapter4_CarpetCalculator ccc = new Chapter4_CarpetCalculator(500, 32);
            ccc.SetNoOfSquareYards(40, 12);
            Console.WriteLine(ccc.ToString());
            
            Chapter4_ParameterClass.RunParameterClass();
            Chapter4_RealEstateApp.RunApp();
            Chapter4_ProgrammingExercises.RunExercises();
            Chapter4_Exercise3_DisplayInfo.CreateStudent();
            
            Chapter4_Exercise4_HouseCalculator houseCalc = new Chapter4_Exercise4_HouseCalculator();
            Console.WriteLine(houseCalc.ToString());
            Chapter4_Example5_TemperatureCalculator.CalculateTemperature(); 
            Chapter4_Example6_CoinCalculator.calculateChange();
            */

            Chapter5 ch5 = new Chapter5();
            /*
            ch5.gradePointAverage();
            ch5.example56(90);

            // Chapter5_BonusCalculator bonusCalculator = new Chapter5_BonusCalculator();
            // bonusCalculator.checkBonus();
            ch5.largestValue(5, 10);
            ch5.largestValue(10, 10);
            ch5.switchStateUSA("MI");
            ch5.switchStateUSA("FL");
            ch5.switchStateUSA("JUHKH");
            ch5.switchStateUSA("tx");
            ch5.switchGrades(30);
            ch5.switchGrades(100);
            ch5.ternaryOperator();
            ch5.multipleChoiceExercises();
            */
            Chapter6 ch6 = new Chapter6();
            /*
            ch6.WhileLoopExample610();
            ch6.ForLoopExamples();
            ch6.ForEachExample612();
            ch6.DoWhileLoop();
            ch6.NestedLoopExample();
            */
            Chapter6_Factorial ch6_fact = new Chapter6_Factorial(); // This is a cool factorial example.
            // ch6_fact.runFactorial();

            // Console.WriteLine(ch6.Fac(4)); // 4x3x2x1 = 24
            // ch6.RecursiveExample(24);
            // ch6.BreakExample();
            // ch6.ContinueExample();
            // ch6.MultipleChoiceQuestions();
            // ch6.Question20();
            // ch6.Question21();
            // ch6.Question22();

            Chapter7 ch7 = new Chapter7();
            /*
            ch7.ArrayBasics();
            ch7.VaryingArguments();
            Console.WriteLine(args.Length);
            ch7.TwoDimensionalSquareArray();
            ch7.JaggedArrayExample();
            ch7.ThreeDimensionalSquareArray();
            
            ch7.ThreeDimensionalSquareArray();
            Console.WriteLine();
            ch7.Question7();
            ch7.Question12();
            ch7.Question15();
            ch7.Question16();
            ch7.Question26();
            ch7.Question27();
            ch7.Exercise10();
            ch7.Question28();
            */
            // Chapter7_CalorieCounter.run();

            // Chapter9_DelegateExample.RunDelegateExample();

            Chapter10_Student aStudent = new Chapter10_Student("12345", "Tim", "Moore", "CS", 111);
            // For aStudent, "CS", 111 is used in the Student class, but everything else is used in the Person class. 
            Console.WriteLine(aStudent.ToString()); // This prints the overridden ToString in the Chapter10_Person 
            Chapter10_Student bStudent = new Chapter10_Student();
            Console.WriteLine(bStudent.ToString());
            bStudent.LastName = "Arnold"; // The child object is assigning data to its parent class. 
            bStudent.FirstName = "Scott";
            Console.WriteLine(bStudent.ToString());
        }
    }


}
