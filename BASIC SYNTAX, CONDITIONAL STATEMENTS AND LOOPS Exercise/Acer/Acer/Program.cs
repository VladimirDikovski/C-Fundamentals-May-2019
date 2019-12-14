using System;

namespace Acer
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string reversePassword = string.Empty;
            int opiti = 0;
            
           

                for (int i = password.Length; i > 0; i--)
                {


                    reversePassword += password[i - 1];
                }
               

            while (true)
            {
                opiti++;
                string currentPassword = Console.ReadLine();
                if (opiti >= 4)
                {
                    Console.WriteLine($"User {password} blocked!");
                    break;
                }

                if (currentPassword == reversePassword)
                {
                    Console.WriteLine($"User {password} logged in.");
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");

                }

            }

        }
    }
}
