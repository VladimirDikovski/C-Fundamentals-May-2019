using System;

namespace Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            double change = 0;
            double currentSum = 0;
            while (true)
            {
                string priceorComand = Console.ReadLine();
                if (priceorComand == "Start")
                {
                    break;
                }
                double StringToDigit = double.Parse(priceorComand);

                if (StringToDigit == 0.1 || StringToDigit == 0.2 || StringToDigit == 0.5 || StringToDigit == 1 || StringToDigit == 2)
                {
                    sum += StringToDigit;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {StringToDigit}");
                }
                
            }
           

            while (true)

            {
                string typeProduct = Console.ReadLine();
                string type = typeProduct;
                currentSum = sum;
                if (typeProduct == "End")
                {
                    break;
                }

                if (typeProduct == "Coke")
                {
                    
                    sum -= 1.0;
                }
                else if(typeProduct== "Soda")
                {
                    sum -= 0.8;
                }
                else if (typeProduct == "Crisps")
                {
                    sum -= 1.5;
                }
                else if (typeProduct == "Water")
                {
                    sum -= 0.7;
                }
                else if (typeProduct == "Nuts")
                {
                    sum -=2.0;
                }
                else
                {
                    Console.WriteLine("Invalid product");
                    continue;
                }

                if (sum < 0)
                {
                    sum = currentSum;
                    Console.WriteLine("Sorry, not enough money");
                    continue;
                }
               
              
                Console.WriteLine($"Purchased {type.ToLower()}");
            }

            Console.WriteLine($"Change: {sum:f2}");




        }
    }
} 
