using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Programming
{
    class Member
    {
        private string id;
        private string firstName;
        private string lastName;
        private string phoneNumber;

        public Member(string firstName, string lastName) // Constructor
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Id { get => id; set => id = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
    }
}
