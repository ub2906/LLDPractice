using System;
using LLDPractice.Interfaces;

namespace LLDPractice.Models
{
    public class LoggingPolicy : IStartPolicy
    {
        public void BeforeStart()
        {
            Console.WriteLine("Ran logging policy on engine before start");
        }
    }
}