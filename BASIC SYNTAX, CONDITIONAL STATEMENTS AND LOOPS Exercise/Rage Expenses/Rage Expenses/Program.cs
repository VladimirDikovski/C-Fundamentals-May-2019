using System;

namespace Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGameCount = int.Parse(Console.ReadLine());
            double headSetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keybordPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            double totalPrice = 0;
            int countTrashHeadSet = 0;
            int countTrashMouse = 0;
            int countTrashKeybord = 0;
            int countTrashDisplay = 0;
            for(int i = 1; i <= lostGameCount; i++)
            {
                if (i % 2 == 0)
                {
                    countTrashHeadSet++;
                }
                if (i % 3 == 0)
                {
                    countTrashMouse++;
                }
                if (i %2== 0 && i%3== 0)
                {
                    countTrashKeybord++;
                    if (countTrashKeybord % 2 == 0)
                    {
                        countTrashDisplay++;
                    }
                }

            }




            if (countTrashDisplay != 0)
            {
                totalPrice = headSetPrice * countTrashHeadSet + mousePrice * countTrashMouse + countTrashKeybord * keybordPrice + countTrashDisplay * displayPrice;
            }
            else
            {
                totalPrice = headSetPrice * countTrashHeadSet + mousePrice * countTrashMouse + countTrashKeybord * keybordPrice;
            }
           
            Console.WriteLine($"Rage expenses: {totalPrice:f2} lv.");
           

            

        }
    }
}
