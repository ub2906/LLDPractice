using LLDPractice.Interfaces;
using LLDPractice.Models;

namespace LLDPractice.Factories
{
    public class ElectricEngineFactory : IEngineFactory
    {
        public IEngine CreateEngine()
        {
            return new ElectricEngine();
        }
    }
}