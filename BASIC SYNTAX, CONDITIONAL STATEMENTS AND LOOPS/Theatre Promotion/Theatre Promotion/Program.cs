﻿using System;

namespace Theatre_Promotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeDay = Console.ReadLine().ToLower(); ;
            int age = int.Parse(Console.ReadLine());
            int price = 0;

            if(typeDay== "weekend")
            {
                if(age>=0 && age <= 18)
                {
                    price = 15;
                }
                else if (age >18 && age <= 64)
                {
                    price = 20;
                }
                else if (age > 64 && age <= 122)
                {
                    price = 15;
                }

              
            }
            if(typeDay== "holiday")
            {
                if(age >= 0 && age <= 18)
                {
                    price = 5;
                }
                else if (age > 18 && age <= 64)
                {
                    price = 12;
                }
                else if (age > 64 && age <= 122)
                {
                    price = 10;
                }
                
            }
            if (typeDay =="weekday")
            {
                if (age >= 0 && age <= 18)
                {
                    price = 12;
                }
                else if (age > 18 && age <= 64)
                {
                    price = 18;
                }
                else if (age > 64 && age <= 122)
                {
                    price = 12;
                }

               
            }
            if (price != 0)
            {
                Console.WriteLine($"{price}$");
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
