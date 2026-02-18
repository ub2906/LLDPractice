using System;
using System.Collections.Generic;
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

            var policies = new List<IStartPolicy>
            {
                new DiagnosticPolicy(),
                new InsurancePolicy(),
                new LoggingPolicy()
            };
            var failureStrategy = new StopOnFirstFailure();
            var compositePolicy = new CompositeStartPolicy(policies, failureStrategy);

            Vehicle car = new Car(name, petrolEngine, compositePolicy);

            Console.WriteLine($"Vehicle created with ID: {car.Id} and Name: {car.Name}");

            car.Start();
            car.Stop();
        }
    }
}
