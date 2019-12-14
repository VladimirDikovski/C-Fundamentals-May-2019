using System;
using System.Collections.Generic;
using System.Linq;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string,Product>();
            
            while (true)
            {
                string[] input = Console.ReadLine().Split(" ");
               

                if(input[0]== "buy")
                {
                    break;
                }

                string product = input[0];
                double price = double.Parse(input[1]);
                int quantity = int.Parse(input[2]);
                Product product1 = new Product(price, quantity);

                if (!dict.ContainsKey(product))
                {
                    dict[product] = product1;
                }
                else
                {
                   
                    dict[product].Quontity += quantity;
                    dict[product].Price = price;

                }

            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value.Price*item.Value.Quontity:f2}");
            }
        }

    }
    class Product
    {
        
        public double Price { get; set; }
        public int Quontity { get; set; }

        public Product(double price,int quontity)
        {
            
            this.Price = price;
            this.Quontity = quontity;
        }
    }
}


