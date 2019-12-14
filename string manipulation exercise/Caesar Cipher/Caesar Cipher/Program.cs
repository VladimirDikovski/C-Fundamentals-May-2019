using System;

namespace Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string encryptedText = string.Empty;

            for (int i = 0; i < text.Length; i++)
            {
                int asci = text[i] + 3;
                char intToAsci = Convert.ToChar(asci);
                encryptedText += intToAsci;

                
            }
            Console.WriteLine(encryptedText);
        }
    }
}
