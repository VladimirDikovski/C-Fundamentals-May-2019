using System;

namespace Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstSymbol = char.Parse(Console.ReadLine());
            char secondSymbol = char.Parse(Console.ReadLine());

            if (firstSymbol > secondSymbol)
            {
                BetwenCharacterRevers(firstSymbol, secondSymbol);
               
            }
            else
            {
                BetweenCharcter(firstSymbol, secondSymbol);
            }

          
           
        }

        static void BetweenCharcter(char symbolOne,char symbolTwo)
        {
            for (int i = symbolOne + 1; i < symbolTwo; i++)
            {

                char b = Convert.ToChar(i);

                Console.Write(b + " ");

            }
        }

        static void BetwenCharacterRevers(char symbolOne, char symbolTwo)
        {
            for (int i = symbolTwo+1; i < symbolOne; i++)
            {

                char b = Convert.ToChar(i);

                Console.Write(b + " ");

            }
        }
    }
}
