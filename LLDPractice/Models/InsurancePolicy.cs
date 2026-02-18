using System;
using LLDPractice.Interfaces;

namespace LLDPractice.Models
{
    public class InsurancePolicy : IStartPolicy
    {
        public void BeforeStart()
        {
            Console.WriteLine("Ran insurance checks on engine before start");
        }
    }
}