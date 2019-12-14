using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int coutPeople = int.Parse(Console.ReadLine());
            string typePeople = Console.ReadLine();
            string day = Console.ReadLine();
            double priceAll = 0;

            if (day == "Friday")
            {
                if (typePeople == "Students")
                {
                    priceAll = coutPeople * 8.45;
                }
                else if (typePeople == "Business")
                {
                    if (coutPeople >= 100)
                    {
                        coutPeople -= 10;

                    }
                    priceAll = coutPeople * 10.90;
                }
                else if (typePeople == "Regular")
                {
                    priceAll = coutPeople * 15;
                }
            }
            else if (day == "Saturday")
            {
                if (typePeople == "Students")
                {
                    priceAll = coutPeople * 9.80;
                }
                else if (typePeople == "Business")
                {
                    if (coutPeople >= 100)
                    {
                        coutPeople -= 10;
                       
                    }
                    priceAll = coutPeople * 15.60;

                }
                else if (typePeople == "Regular")
                {
                    priceAll = coutPeople * 20;
                }
            }
            else if(day == "Sunday")
            {
                if (typePeople == "Students")
                {
                    priceAll = coutPeople * 10.46;
                }
                else if (typePeople == "Business")
                {
                    if (coutPeople >= 100)
                    {
                        coutPeople -= 10;

                    }
                    priceAll = coutPeople * 16;
                }
                else if (typePeople == "Regular")
                {
                    priceAll = coutPeople * 22.50;
                }
            }
            if (coutPeople >= 30 && typePeople == "Students")
            {
                priceAll *= 0.85;

            }
          

            if (coutPeople >= 10 && coutPeople <= 20 && typePeople == "Regular")
            {
                priceAll *= 0.95;
            }

           
                Console.WriteLine($"Total price: {priceAll:F2}");
            
        }
    }
}
