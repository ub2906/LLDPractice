using LLDPractice.Interfaces;
using LLDPractice.Models;
using LLDPractice.Patterns;

namespace LLDPractice.Factories
{
    public class PetrolVehicleFactory : IVehicleFactory
    {
        public IEngine CreateEngine()
        {
            return new PetrolEngine();
        }

        public IStartPolicy CreateStartPolicy()
        {
            return new InsurancePolicy();
        }

        public Vehicle CreateVehicle(string name)
        {
            IVehicleBuilder<Car> builder = new CarBuilder();

            return builder
                .SetName(name)
                .SetEngine(CreateEngine())
                .SetStartPolicy(CreateStartPolicy())
                .Build();
        }
    }
}