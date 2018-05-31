using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        private static List<Student> list = new List<Student>();

        static void Main(string[] args)
        {
            GenerateMenu();
        }

        public static void AddStudent()
        {
            var student = new Student();
            Console.WriteLine("Please enter student rollNumber");
            student.RollNumber = Console.ReadLine();
            Console.WriteLine("Please enter student name");
            student.Name = Console.ReadLine();
            Console.WriteLine("Please enter student address");
            student.Address = Console.ReadLine();
            Console.WriteLine("Please enter student email");
            student.Email = Console.ReadLine();
            list.Add(student);
        }

        public static void ShowList()
        {
            foreach (var student in list)
            {
                Console.WriteLine(student.Name);
            }
        }

        public static void SearchStudent()
        {
            Console.WriteLine("Please enter search name");
            var searchName = Console.ReadLine();
            foreach (var student in list)
            {
                if (searchName.Equals(student.Name))
                {
                    Console.WriteLine("rollNumber: " + student.RollNumber);
                    Console.WriteLine("address: " + student.Address);
                    Console.WriteLine("email: " + student.Email);
                }
            }
        }

        public static void GenerateMenu()
        {
            while (true)
            {
                Console.WriteLine("-----------Student-----------");
                Console.WriteLine("1. Add new student");
                Console.WriteLine("2. Show list student");
                Console.WriteLine("3. Search student by name");
                Console.WriteLine("4. Exit");
                var choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddStudent();
                        break;
                    case 2:
                        ShowList();
                        break;
                    case 3:
                        SearchStudent();
                        break;
                    case 4:
                        Environment.Exit(1);
                        break;
                }
            }
        }
    }
}