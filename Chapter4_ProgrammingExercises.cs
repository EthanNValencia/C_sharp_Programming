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
    }
    class Chapter4_Exercise3_DisplayInfo
    {

    }
}
