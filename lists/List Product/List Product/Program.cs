using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Product
{
    class Program
    {
        static void Main(string[] args)
        {
            int nProduct = int.Parse(Console.ReadLine());

            SortProducts(nProduct);
        }

        static void SortProducts(int nProduct)
        {
            List<string> product = new List<string>();
            for (int i = 0; i < nProduct; i++)
            {
                product.Add(Console.ReadLine());

            }

            product.Sort();
            for (int i = 0; i < product.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{product[i]}");
            }
        }
    }
}
