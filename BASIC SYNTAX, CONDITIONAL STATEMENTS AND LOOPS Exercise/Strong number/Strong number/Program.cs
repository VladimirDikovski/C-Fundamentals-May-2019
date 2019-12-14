using System;

namespace Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string inversion = number.ToString();
            long fakturiel = 1;

            long sum = 0;

            for(int i = 0; i < inversion.Length; i++)
            {
                char b = inversion[i];
                int digit = (int)Char.GetNumericValue(b);
                

                for(int j = 1; j <=digit; j++)
               {
                   
                    fakturiel *= j;
                    
                    
               }
                sum += fakturiel;
               
                fakturiel = 1;
               
            }
            if (sum == number)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
