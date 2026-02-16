using System;
using LLDPractice.Interfaces;

namespace LLDPractice.Models
{
    public class PetrolEngine: IEngine
    {
        public void Start()
        {
            Console.WriteLine("Starting Petrol Engine");
        }

        public void Stop()
        {
            Console.WriteLine("Stopping PetrolEngine");
        }
    }
}
