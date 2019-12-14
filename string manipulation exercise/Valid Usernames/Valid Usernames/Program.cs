using System;

namespace Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] userNames = Console.ReadLine().Split(", ");
          

            for (int i = 0; i < userNames.Length; i++)
            {
                bool IsLenght = true;
                bool IsContainLatters = true;
                string firstLater = userNames[i];

                if (firstLater.Length < 3 || firstLater.Length > 16)
                {
                    IsLenght = false;
                    continue;
                }

                for (int j = 0; j < firstLater.Length; j++)
                {
                    if (!char.IsLetterOrDigit(firstLater[j]) && firstLater[j] != '-' && firstLater[j] != '_')
                    {
                        IsContainLatters = false;
                        break;
                    }
                }

                if (IsLenght && IsContainLatters)
                {
                    Console.WriteLine(firstLater);
                }


            }


        }
    }
}
