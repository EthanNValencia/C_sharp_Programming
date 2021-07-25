using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Programming
{
    class Chapter10_Student : Chapter10_Person // Student is derrived from Person, a Student IS A Person.
    {
        private string major;
        private int studentId;
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
        public override int getSleepAmt()
        {
            return 6;
        }
    }
}
