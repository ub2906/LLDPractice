using LLDPractice.Interfaces;
using LLDPractice.Models;

namespace LLDPractice.Factories
{
    public class PetrolEngineFactory : IEngineFactory
    {
        public IEngine CreateEngine()
        {
            return new PetrolEngine();
        }
    }
}