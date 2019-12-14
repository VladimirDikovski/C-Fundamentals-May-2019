using System;
using System.Collections.Generic;
using System.Linq;

namespace Students_2._0
{
    class Student
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public string homeTown { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> listStudents = new List<Student>();

            while (true)
            {
                List<string> Input = Console.ReadLine().Split(" ").ToList();

                if (Input[0] == "end")
                {
                    break;
                }
                Student newStudent = new Student();
                newStudent.firstName = Input[0];
                newStudent.lastName = Input[1];
                newStudent.age = int.Parse(Input[2]);
                newStudent.homeTown = Input[3];
                listStudents.Add(newStudent);
                
               
                
            }

            string city = Console.ReadLine();

          
        }
    }
}
