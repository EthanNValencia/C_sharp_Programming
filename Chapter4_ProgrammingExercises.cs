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
     * 
     * Create a class representing a student. Create a second class that instantiates the first
     * class with inforamtion about yourself. In the second class, create a class method that
     * displays your name and GPA. 
     * 
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
}
