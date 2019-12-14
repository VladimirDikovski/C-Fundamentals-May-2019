using System;
using System.Collections.Generic;
using System.Linq;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            int countStudents = int.Parse(Console.ReadLine());

            for (int i = 0; i < countStudents; i++)
            {
                string[] input = Console.ReadLine().Split(" ");

                string firstName = input[0];
                string lastName = input[1];
                double grade = double.Parse(input[2]);

                Student newStuden = new Student(firstName, lastName, grade);
                students.Add(newStuden);

            }

            students = students.OrderByDescending(x => x.Grade).ToList();

            Console.WriteLine(string.Join(Environment.NewLine,students));
        }
    }

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }


        public Student(string firstName ,string lastName,double grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }

        public Student()
        {
            this.LastName = null;
            this.FirstName = null;
            this.Grade = 0;
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName}: {this.Grade:f2}";
        }
    }
}
