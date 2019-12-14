using System;
using System.Numerics;
namespace Big_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger fakturiel = 1;
            BigInteger result = FakturielOfN(n, fakturiel);
            Console.WriteLine(result);

           
        }

        static BigInteger FakturielOfN(int n ,BigInteger fakturiel)
        {
            for (int i = 1; i <= n; i++)
            {
                fakturiel *= i;

            }
            return fakturiel;
        }
    }
}
