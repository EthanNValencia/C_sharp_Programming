using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Programming
{
    class Chapter4_ProgrammingExercises
    {
        public static void RunExercises()
        {
            Chapter4_Exercise1.DisplaySchoolData();

            Chapter4_Exercise2.DisplayFavoriteSaying(Chapter4_Exercise2.EnterFavoriteSaying());
        }
    }

    /*
     * Exercise 1 pg 206
     * Write an application that calls a class method to display information about your school. 
     * Items you might include are the name of your school, number of students enrolled, and 
     * school colors. 
     * The display should asethetically pleasing. 
     */
    class Chapter4_Exercise1
    {
        public static void DisplaySchoolData()
        {
            string schoolName = "Valencia College";
            int numberOfStudents = 38107;
            string schoolColor = "Red";
            Console.WriteLine("School Name:        " + schoolName
                          + "\nNumber of Students: " + numberOfStudents
                          + "\nSchool Color:       " + schoolColor);
        }
    }
    /*
     * Exercise 2 pg 206
     * Design a message display application. Allow users to enter their favorite sayings in a class 
     * method. Return the saying back to the main() method. Call another method, sending the saying. 
     * From that method, display the message surrounded by the lines of astericks. 
     */
    class Chapter4_Exercise2
    {
        public static string EnterFavoriteSaying()
        {
            string input; 
            Console.Write("Enter your favorite saying: ");
            input = Console.ReadLine();
            return input;
        }

        public static void DisplayFavoriteSaying(string saying)
        {
            Console.WriteLine("**** " + saying + " ****");
        }

    }

    /*
     * Exercise 3 pg 206
     * Create a class representing a student. Incude characteristics such as first and last
     * name, overall GPA, classification, and major. Write at least two constructors. Include
     * properties for each of the data items. Create a second class that instantiates the first
     * class with inforamtion about yourself. In the second class, create a class method that
     * displays your name and GPA. 
     */
    class Chapter4_Exercise3_Student
    {
        string firstName;
        string lastName;
        double overallGPA;
        string classification;
        string major; 

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value; 
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public string Classification
        {
            get
            {
                return classification;
            }
            set
            {
                classification = value;
            }
        }

        public string Major
        {
            get
            {
                return major;
            }
            set
            {
                major = value;
            }
        }

        public double OverallGPA
        {
            get
            {
                return overallGPA;
            }
            set
            {
                overallGPA = value; 
            }
        }

        public Chapter4_Exercise3_Student(string firstName, string lastName, double overallGPA, string classification, string major)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.overallGPA = overallGPA;
            this.classification = classification;
            this.major = major;
        }

        public Chapter4_Exercise3_Student()
        {
            // Just a zero parameter default constructor. 
        }
    }
    class Chapter4_Exercise3_DisplayInfo
    {
        public static void CreateStudent()
        {
            Chapter4_Exercise3_Student student = new Chapter4_Exercise3_Student();
            string input;
            Console.WriteLine("Enter first name: ");
            student.FirstName = Console.ReadLine();
            Console.WriteLine("Enter last name: ");
            student.LastName = Console.ReadLine();
            Console.WriteLine("Enter overall GPA: ");
            input = Console.ReadLine();
            student.OverallGPA = double.Parse(input);
            Console.WriteLine("Enter classification: ");
            student.Classification = Console.ReadLine();
            Console.WriteLine("Enter major: ");
            student.Major = Console.ReadLine();
            Console.WriteLine("Your name is " + student.FirstName + " " + student.LastName + "\nYour classification is " + student.Classification + " and your major is " + student.Major + "\nYour GPA is " + student.OverallGPA);
        }
    }

    /*
     * Exercise 4, pg 206
     * Design an application using methods that display the number of square feet in a house. 
     * Allow the user to enter values for the length and width of the house. Use class methods
     * for entering values, performing the computation, and displaying the results. The results
     * should include the original measurements entered by the user. 
     */
    class Chapter4_Exercise4_HouseCalculator
    {
        private int lengthFT;
        private int widthFT;
        private int squareFT;

        public Chapter4_Exercise4_HouseCalculator()
        {
            string input;
            Console.Write("Please input the length of the house: ");
            input = Console.ReadLine();
            this.lengthFT = int.Parse(input);
            Console.Write("Please input the width of the house: ");
            input = Console.ReadLine();
            this.widthFT = int.Parse(input);
            squareFT = this.lengthFT * this.widthFT;
        }

        public override string ToString()
        {
            return "For a house with the dimensions of " + this.lengthFT + " by " + this.widthFT + " the total sqft is " + this.squareFT + ".";
        }

        public int LengthFT
        {
            get
            {
                return lengthFT;
            }
        }
        public int WidthFT
        {
            get
            {
                return widthFT;
            }
        }
        public int SquareFT
        {
            get
            {
                return squareFT;
            }
        }
    }

    /*
     * Exercise 5, pg 206
     * Write a program that converts temperture given in celsius to farenheit. Allow the user
     * to enter values for the original celsius value. Display the original temperataure and
     * the formatted convereted value. Use appropriate methods for entering, calculating, and
     * outputting results. 
     */
    class Chapter4_Example5_TemperatureCalculator
    {

    }

    /*
     * Exercise 6, pg 206
     * Write a program that prints the number of quarters, dimes, nickels, and pennies that a
     * customer should get back as change. Allow the user to enter any value less than $1.00
     * in a method. Call on seperate methods for each of the calculations. 
     */
    class Chapter4_Example5_CoinCalculator
    {
        const int QUARTER = 25;
        const int DIME = 10;
        const int NICKEL = 5;
        const int PENNY = 1;
        static int quarter, dime, nickel, penny, centInput;
        static string input;
        static Boolean finished = false; 

        public static void calculateChange()
        {
            Console.Write("Input amount of cents (less than 100): ");
            input = Console.ReadLine();
            centInput = int.Parse(input);

            Check(ref quarter, QUARTER);
            Check(ref dime, DIME);
            Check(ref nickel, NICKEL);
            Check(ref penny, PENNY);

            Console.WriteLine("For " + input + " cents your change will be:\n" +
                              "Quarters: " + quarter + "\n" + 
                              "Dimes: " + dime + "\n" +
                              "Nickels: " + nickel + "\n" +
                              "Pennies: " + penny);
        }

        public static void Check(ref int countCoinType, int coinCheck) // Cool use of the ref type implemented here. 
        {
            while (finished == false)
            {
                if (centInput - coinCheck >= 0)
                {
                    countCoinType++;
                    centInput -= coinCheck;
                }
                else
                {
                    finished = true;
                }
            }
            finished = false;
        }
    }
}
