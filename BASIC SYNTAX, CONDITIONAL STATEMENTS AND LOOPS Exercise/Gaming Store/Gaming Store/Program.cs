using System;

namespace Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());
            double currentBlance = balance;
         
            double diff = 0;

            while(true){

                string game = Console.ReadLine();
                
               
                if (game== "Game Time")
                {
                    break;
                }
                if (game == "OutFall 4")
                {
                    if (balance < 39.99 )
                    {
                        Console.WriteLine("Too Expensive");
                        continue;
                    }
                    balance -= 39.99;
                }
                else if(game== "Zplinter Zell")
                {
                    if (balance < 19.99)
                    {
                        Console.WriteLine("Too Expensive");
                        continue;
                    }
                    balance -= 19.99;
                }
                else if (game == "CS:OG")
                {
                    if (balance < 15.99 )
                    {
                        Console.WriteLine("Too Expensive");
                        continue;
                    }
                    balance -= 15.99;
                }
                else if(game== "Honored 2")
                {
                    if (balance <=59.99 )
                    {
                        Console.WriteLine("Too Expensive");
                        continue;
                    }
                    balance -= 59.99;
                }
                else if(game== "RoverWatch")
                {
                    if (balance < 29.99 )
                    {
                        Console.WriteLine("Too Expensive");
                        continue;
                    }
                    balance -= 29.99;
                }
                else if (game == "RoverWatch Origins Edition")
                {
                    if (balance <39.99 )
                    {
                        Console.WriteLine("Too Expensive");
                        continue;
                    }
                    balance -= 39.99;
                }
                else
                {

                    Console.WriteLine("Not Found");
                    continue;
                    
                }
                Console.WriteLine($"Bought {game}");
                if (balance == 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }
                if (balance < 15.99)
                {
                    break;
                }


                
            }
            if (balance!= 0)
            {
                diff = Math.Abs(balance - currentBlance);
                Console.WriteLine($"Total spent: ${diff:F2}. Remaining: ${balance:F2}");
            }
            

        }
    }
}
