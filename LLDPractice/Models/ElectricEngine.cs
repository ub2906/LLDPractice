using System;
using LLDPractice.Interfaces;

namespace LLDPractice.Models
{
    public class ElectricEngine: IEngine
    {
        public void Start()
        {
            Console.WriteLine("Starting Electric Engine");
        }

        public void Stop()
        {
            Console.WriteLine("Stopping Electric Engine");
        }
        public double FuelConsumptionPerSecond()
        {
            return 0.5;
        }
    }

}