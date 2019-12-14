using System;

namespace Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] elements = Console.ReadLine().Split(" "); 

            for(int i = 0; i < elements.Length; i++)
            {
                Console.Write(elements[elements.Length-i-1] +" ");
            }
        }
    }
}
