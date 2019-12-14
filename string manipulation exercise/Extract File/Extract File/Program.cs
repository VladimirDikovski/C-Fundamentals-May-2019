using System;

namespace Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split(new char[] {'\\', '.' });

            string faillName = input[input.Length - 2];
            string extension = input[input.Length - 1];

            Console.WriteLine($"File name: {faillName}");
            Console.WriteLine($"File extension: {extension}");

            
            
        }
    }
}
