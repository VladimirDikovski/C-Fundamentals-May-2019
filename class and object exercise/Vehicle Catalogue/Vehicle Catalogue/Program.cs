using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> Vehicles2 = new List<Vehicle>();
            List<Vehicle> Vehicles = new List<Vehicle>();
            List<Vehicle> AveraglesListCar= new List<Vehicle>();
            List<Vehicle> AveraglesListTruck = new List<Vehicle>();
            double result = 0;
            double result2 = 0;


            while (true)
            {
                string[] input = Console.ReadLine().Split(" ");
                if (input[0] == "End")
                {
                    break;
                }
                string type = input[0];
                string model = input[1];
                string color = input[2];
                int horsepower = int.Parse(input[3]);

                Vehicle newVelicle = new Vehicle(type, model, color, horsepower);
                Vehicles.Add(newVelicle);
                AveraglesListCar = Vehicles.Where(x => x.Type == "car").ToList();
                AveraglesListTruck = Vehicles.Where(x => x.Type == "truck").ToList();
            }
           
            while(true)
                
            {
                string typeVelicles = Console.ReadLine();
                if (typeVelicles == "Close the Catalogue")
                {
                    break;
                }
                Vehicles2 = Vehicles.Where(x => x.Model == typeVelicles).ToList();

                foreach (var item in Vehicles2)
                {
                    Console.WriteLine(item);
                   
                }




            }
            if (AveraglesListCar.Count > 0)
            {
                result = AveraglesListCar.Average(x => x.Horsepower);
                
            }

            Console.WriteLine($"Cars have average horsepower of: {result:F2}.");
            if (AveraglesListTruck.Count > 0)
            {
                result2 = AveraglesListTruck.Average(x => x.Horsepower);
               

            }

            Console.WriteLine($"Trucks have average horsepower of: {result2:F2}.");

        }
       
    }

    class Vehicle
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Horsepower { get; set; }

        public Vehicle(string type,string model,string color,int horsepower)
        {
            this.Type = type;
            this.Model = model;
            this.Color = color;
            this.Horsepower = horsepower;
        }

        public override string ToString()
        {
            string vehicleStr = $"Type: {(this.Type == "car" ? "Car" : "Truck")}{Environment.NewLine}" +
                                $"Model: {this.Model}{Environment.NewLine}" +
                                $"Color: {this.Color}{Environment.NewLine}" +
                                $"Horsepower: {this.Horsepower}";

            return vehicleStr;
        }

    }
}
