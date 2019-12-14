using System;
using System.Collections.Generic;
using System.Linq;

namespace Store_Boxes
{
  public  class Item
    {
        public string name { get; set; }
        public double price { get; set; }
    }
  public  class Box
    {
       public string serialNumber { get; set; }
       public string Item { get; set; }
      public int quontity {get;set;}
       public double price { get; set; }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Box newBox = new Box();
            Item newItem = new Item();
            double PriceOfOneBox = 0;
            List<Box> HoldResult = new List<Box>();
            List<double> priceResult = new List<double>();
            
            while (true)
            {
                List<string> Input = Console.ReadLine().Split(" ").ToList();
                if (Input[0] == "end")
                {
                    break;
                }

                newBox.serialNumber = Input[0];
                newBox.Item = Input[1];
                newBox.quontity = int.Parse(Input[2]);
                newBox.price = double.Parse(Input[3]);

                double priceForbox = newBox.quontity * newBox.price;

                HoldResult.Add(newBox);
                priceResult.Add(priceForbox);

            }

            priceResult.Sort();
            foreach (Box item in HoldResult)
            {
                Console.WriteLine(item.serialNumber);
                Console.WriteLine();
            }
          
                   
                   
                

          
            
          
            
        }
    }
}
