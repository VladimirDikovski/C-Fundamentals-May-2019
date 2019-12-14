using System;
using System.Collections.Generic;
using System.Text;

namespace justTest
{
   public class Cat
    {
       public string name { get; set; }
       public string color { get; set; }

      public Cat(string name,string color)
        {
            this.name = name;
            if (name.Length < 2)
            {
                throw new Exception("Error");
            }
            this.color = color;
        }

        public void SayMeo()
        {
            Console.WriteLine("Meo");
        }
    }
}
