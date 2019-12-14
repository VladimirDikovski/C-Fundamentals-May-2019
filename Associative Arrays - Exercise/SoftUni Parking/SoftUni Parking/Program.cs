using System;
using System.Linq;
using System.Collections.Generic;
namespace SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int countPeople = int.Parse(Console.ReadLine());

            var dict = new Dictionary<string,string>();

            for (int i = 0; i < countPeople; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                string operation = input[0];
                if (operation== "register")
                {
                    dict = RegisterUser(dict, input);
                   
                }
                else
                {
                    dict = UnregisterUser(dict, input);
                }
            
            }

            PrintDict(dict);
          
        }

        public static Dictionary<string,string>RegisterUser(Dictionary<string,string> dict,string[]input)
        {
            string keyvalue = input[1];
            string value = input[2];

            if (!dict.ContainsKey(keyvalue))
            {
                dict[keyvalue] = value;
                Console.WriteLine($"{keyvalue} registered {value} successfully");
            }
            else
            {
                Console.WriteLine($"ERROR: already registered with plate number {value}");
            }

            return dict;
        }

        public static Dictionary<string, string> UnregisterUser(Dictionary<string, string> dict, string[] input)
        {
            string keyvalue = input[1];

            if (!dict.ContainsKey(keyvalue))
            {
                Console.WriteLine($"ERROR: user {keyvalue} not found");
            }

            else
            {
                dict.Remove(keyvalue);
                Console.WriteLine($"{keyvalue} unregistered successfully");
            }
            return dict;
        }

        public static void PrintDict(Dictionary<string, string> dict)
        {
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
