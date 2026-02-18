using System;
using LLDPractice.Interfaces;

namespace LLDPractice.Models
{
    public class DiagnosticPolicy: IStartPolicy
    {
        public void BeforeStart()
        {
            Console.WriteLine("Ran diagnostics on engine before start");
        }
    }
}