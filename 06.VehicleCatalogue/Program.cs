using System.Drawing;
using System.Reflection;

namespace _06.VehicleCatalogue
{
    class Vehicle
    {
        public Vehicle(string typeOfVehicle, string model, string color, double horsepower)
        {
            Type = typeOfVehicle;
            Model = model;
            Color = color;
            Power = horsepower;
        }

        public string Type;
        public string Model;
        public string Color;
        public double Power;

        public override string ToString()
        {
            return $"Type: {Type}\n" +
                $"Model: {Model}\n" +
                $"Color: {Color}\n" +
                $"Horsepower: {Power}";
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            var vehicles = new List<Vehicle>();

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] commands = command.Split();

                string typeOfVehicle = commands[0];
                if (typeOfVehicle == "car")
                {
                    typeOfVehicle = "Car";
                }
                else
                {
                    typeOfVehicle = "Truck";
                }
                string model = commands[1];
                string color = commands[2];
                double horsepower = double.Parse(commands[3]);

                Vehicle vehicle = new Vehicle(typeOfVehicle, model, color, horsepower);

                vehicles.Add(vehicle);
            }

            string vehicleModel;
            while ((vehicleModel = Console.ReadLine()) != "Close the Catalogue")
            {
                Vehicle found = vehicles.FirstOrDefault(v => v.Model == vehicleModel); // това какво е точно, нов обект тип нашия клас?

                if (found != null)
                {
                    Console.WriteLine(found);
                }
            }

            double averageHP = vehicles
            .Where(vehicle => vehicle.Type == "Car")
            .Select(vehicle => vehicle.Power)
            .DefaultIfEmpty()
            .Average();
            Console.WriteLine($"Cars have average horsepower of: {averageHP:F2}.");

            averageHP = vehicles
                .Where(vehicle => vehicle.Type == "Truck")
                .Select(vehicle => vehicle.Power)
                .DefaultIfEmpty()
                .Average();
            Console.WriteLine($"Trucks have average horsepower of: {averageHP:F2}.");
        }
    }
}
