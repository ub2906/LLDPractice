using System;
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
            Vehicle car = new Car(name, petrolEngine);

            Console.WriteLine($"Vehicle created with ID: {car.Id} and Name: {car.Name}");

            car.Start();
            car.Stop();
        }
    }
}
