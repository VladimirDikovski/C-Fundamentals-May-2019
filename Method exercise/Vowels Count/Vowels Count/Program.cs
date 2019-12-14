using System;

namespace Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string  name = Console.ReadLine();
            VowelsCount(name);


            
        }

        static void VowelsCount(string name)
        {
            
            int countVowels = 0;
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] == 'a' || name[i] == 'e' || name[i] == 'i' || name[i] == 'o' ||
                    name[i] == 'u' || name[i] == 'A' || name[i] == 'E' || name[i] == 'I'
                    || name[i] == 'I' || name[i] == 'O' || name[i] == 'U')
                {
                    countVowels++;
                }
            }
            Console.WriteLine(countVowels);
        }
    }

  
}
