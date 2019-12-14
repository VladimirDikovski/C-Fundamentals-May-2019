using System;

namespace Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYeild = int.Parse(Console.ReadLine());
            int spiceMined = 0;
            int dropdownconstant = 10;
            int workerConsume = 26;
            int days = 0;
          
            

            while (startingYeild >= 100)
            {
                
                    spiceMined += startingYeild;
                    spiceMined -= workerConsume;
                    startingYeild -= dropdownconstant;
                    days++;
                
            }
            if (spiceMined != 0)
            {
                spiceMined-= 26;
            }
            

            Console.WriteLine(days);
            Console.WriteLine(spiceMined);

            
        }
    }
}
