using System;
using System.Linq;
using System.Collections.Generic;

namespace SoftUni_Exam_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            var namePoint = new Dictionary<string,int>();
            var nameLanguage= new Dictionary<string, List<string>>();

            while (true)
            {
                string[] input = Console.ReadLine().Split("-");

                string name = input[0];
                string Language = input[1];
               
                if (input[0] == "exam finished")
                {
                    break;
                }
                if (input[1] == "banned")
                {
                    nameLanguage.Remove(name);
                }
                if(input[1] != "banned")
                {
                    int point = int.Parse(input[2]);
                    if (!namePoint.ContainsKey(name))
                    {
                        namePoint[name] = point;
                       
                    }
                    else
                    {
                       name
                    }
                }
            
            
            }
        }
  }

  
}

