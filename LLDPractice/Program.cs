using System;
using System.Collections.Generic;
using LLDPractice.Patterns;
using LLDPractice.Models;
using LLDPractice.Interfaces;
using LLDPractice.Factories;

namespace LLDPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //IEngine petrolEngine = new PetrolEngine();
            //IEngine electicEngine = new ElectricEngine();
            // IEngineFactory engineFactory = new PetrolEngineFactory();
            // IEngine engine = engineFactory.CreateEngine();

            //var name = VehicleName.Create("Sedan");

            //var startPolicy = StartPolicyBuilder.Build(EnvironmentType.Production);

            //Vehicle vehicle = new Car(name, engine, startPolicy);

            var name = "Sedan";
            
            IVehicleFactory factory = new PetrolVehicleFactory();
            var vehicle = factory.CreateVehicle(name);

            Console.WriteLine($"Vehicle created with ID: {vehicle.Id} and Name: {vehicle.Name}");

            vehicle.Start();
            Console.WriteLine(vehicle.FuelConsumptionPerSecond());
            vehicle.Stop();
            Console.WriteLine(vehicle.FuelConsumptionPerSecond());
        }
    }
}
