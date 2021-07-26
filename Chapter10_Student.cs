using System;
using System.Collections.Generic;
using System.Text;
/*
 * This is an example of how inheritance syntax is layed out in C#. 
 * Java uses the super keyword, but C# uses base. 
 * 
 */
namespace C_sharp_Programming
{
    class Chapter10_Student : Chapter10_Person // Student is derrived from Person, a Student IS A Person.
    {
        private string major;
        private int studentId;

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
        public int StudentId
        {
            get
            {
                return studentId;
            }
            set
            {
                studentId = value;
            }
        }

        public Chapter10_Student() : base() // This means that no arguments being sent to base() constructor. 
        {
            major = "unknown";
            studentId = 0;
        }
        public Chapter10_Student(string id, string fname, string lname, string maj, int sId) : base(id, lname, fname)
        {
            /*
             * id, lname, and fname are sent to the base 3-param constructor. 
             */
            major = maj;
            studentId = sId;
        }
        public override int GetSleepAmt()
        {
            return 6;
        }
        public int CallOverriddenGetSleepAmt() 
        {
            /*
             * If you wish to override a base method, but still want to have access to it, 
             * then this is a good way of doing it. Create a method that calls the base method. 
             */
            return base.GetSleepAmt();
        }
    }
}
