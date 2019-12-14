using System;

namespace Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int threeNumber = int.Parse(Console.ReadLine());

            SmallerNubmers(firstNumber, secondNumber, threeNumber);

        }

        static void SmallerNubmers(int first,int second,int three)
        {
           if(first<second && first<three )
            {
                Console.WriteLine(first);
            }
           

           else if(second<first && second < three)
            {
                Console.WriteLine(second);
            }
           else if(three<first && three < second)
            {
                Console.WriteLine(three);
            }

            else
            {
                Console.WriteLine(three);
            }
        }
    }
}
