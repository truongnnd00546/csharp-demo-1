using System;

namespace ConsoleApp1
{
    public class Student
    {
        private String rollNumber;
        private String name;
        private String address;
        private String email;

        public string RollNumber
        {
            get => rollNumber;
            set => rollNumber = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Address
        {
            get => address;
            set => address = value;
        }

        public string Email
        {
            get => email;
            set => email = value;
        }

        public Student()
        {
        }

        public Student(string rollNumber, string name, string address, string email)
        {
            this.rollNumber = rollNumber;
            this.name = name;
            this.address = address;
            this.email = email;
        }
    }
}