using System;
using System.Collections.Generic;
using System.Text;
/*
 * This is the base or parent class of the Chapter10_Student class. 
 * Refer to Chapter10_Student for an example of inheritance. 
 * 
 */
namespace C_sharp_Programming
{
    class Chapter10_Person // Example 10-1, pg 582
    {
        private string idNumber;
        private string lastName;
        private string firstName;
        private int age;

        public string IDNumber 
        {
            get
            {
                return idNumber;
            }
            set
            {
                idNumber = value;
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
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public Chapter10_Person()
        {
            idNumber = "";
            lastName = "unknown";
            firstName = string.Empty;
            age = 0;
        }
        public Chapter10_Person(string id)
        {
            idNumber = id;
            lastName = "unknown";
            firstName = string.Empty;
            age = 0;
        }
        public Chapter10_Person(string id, string lname, string fname)
        {
            idNumber = id;
            lastName = lname;
            firstName = fname;
            age = 0;
        }
        public Chapter10_Person(string id, string lname, string fname, int anAge)
        {
            idNumber = id;
            lastName = lname;
            firstName = fname;
            age = anAge;
        }
        public override string ToString()
        {
            /*
             * In the object class, the ToString method looks like this:
             * public virtual string ToString();
             */
            return firstName + " " + lastName;
        }
        public virtual int GetSleepAmt() // Virtual means that the method can be overridden in the child class. 
        {
            return 8;
        }
    }
}
