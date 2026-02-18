using System;
using System.Collections.Generic;
using LLDPractice.Patterns;
using LLDPractice.Models;
using LLDPractice.Interfaces;

namespace LLDPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            IEngine petrolEngine = new PetrolEngine();
            var name = VehicleName.Create("Sedan");

            var startPolicy = StartPolicyBuilder.Build(EnvironmentType.Production);

            Vehicle car = new Car(name, petrolEngine, startPolicy);

            Console.WriteLine($"Vehicle created with ID: {car.Id} and Name: {car.Name}");

            car.Start();
            car.Stop();
        }
    }
}
