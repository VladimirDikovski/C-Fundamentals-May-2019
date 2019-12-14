using System;
using System.Collections.Generic;
using System.Linq;

namespace Order_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(" ");
                if (input[0] == "End")
                {
                    break;
                }

                string firstname = input[0];
                string id = input[1];
                int age = int.Parse(input[2]);

                Student newStudent = new Student(firstname, id, age);
                students.Add(newStudent);
                
            }
            students = students.OrderBy(x => x.Age).ToList();

            Console.WriteLine(string.Join(Environment.NewLine,students));
          
        }
    }

    class Student
    {
        public string FirstName { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }

        public Student(string firstName ,string id ,int age)
        {
            this.FirstName = firstName;
            this.ID = id;
            this.Age = age;
        }

        public override string ToString()
        {
            return $"{this.FirstName} with ID: {this.ID} is {this.Age} years old.";
        }
    }
}
