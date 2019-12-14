using System;

namespace Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budgete = double.Parse(Console.ReadLine());
            int countStudent = int.Parse(Console.ReadLine());
            double pricelightsabers = double.Parse(Console.ReadLine());
            double priceRobe = double.Parse(Console.ReadLine());
            double priceBelt = double.Parse(Console.ReadLine());
            double diffrent = 0;
            int pricebeltLess = 0;
            pricebeltLess = countStudent / 6;
            
            


            double totalPrice =( pricelightsabers * (Math.Ceiling(countStudent * 1.1)) + priceRobe * countStudent + priceBelt * (countStudent-pricebeltLess));
            

            if (totalPrice <= budgete)
            {
              Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
          }
           else
           {
               diffrent = Math.Abs(totalPrice - budgete);
               Console.WriteLine($"Ivan Cho will need {diffrent:f2}lv more.");
           }

        }
    }
}
