using System;
using System.Collections.Generic;

namespace justTest
{
    class Program
    {
        static void Main(string[] args)
        {

            Cat kotka = new Cat("Ivan","Pesho");



            kotka.SayMeo();
            Console.WriteLine(kotka.name);


        }
    }
}
