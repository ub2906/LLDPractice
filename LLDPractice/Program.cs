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
            Vehicle car = new Car("Sedan", petrolEngine);

            Console.WriteLine($"Vehicle name : {car.Name}");

            car.Start();
            car.Stop();
        }
    }
}
