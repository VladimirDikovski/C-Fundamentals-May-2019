using System;
using System.Collections.Generic;
using System.Linq;

namespace Students
{
    public class Students
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public string homeTown { get; set; }

    }

    public class Program
    {
        static void Main(string[] args)
        {
            List<Students> ListOFstudents = new List<Students>();
          
            while (true)
            {
                List<string> Input = Console.ReadLine().Split(" ").ToList();
                if (Input[0] == "end")
                {
                    break;

                }

                string fName = Input[0];
                string lName = Input[1];
                int age = int.Parse(Input[2]);
                string hometown = Input[3];
                Students student = new Students()
                {
                    firstName = fName,
                    lastName = lName,
                    age = age,
                    homeTown = hometown
                };

                ListOFstudents.Add(student);
            }
            string filterCyti = Console.ReadLine();

            foreach (Students student in  ListOFstudents)
            {
                if (student.homeTown== filterCyti)
                {
                    Console.WriteLine($"{student.firstName} {student.lastName} is {student.age} years old.");
                }
            }
            
        }
    }
   
}

   


