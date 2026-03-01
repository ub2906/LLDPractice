using LLDPractice.Interfaces;
using LLDPractice.Models;
using LLDPractice.Patterns;

namespace LLDPractice.Factories
{
    public class ElecticVehicleFactory : IVehicleFactory
    {
        public IEngine CreateEngine()
        {
            return new ElectricEngine();
        }

        public IStartPolicy CreateStartPolicy()
        {
            return new LoggingPolicy();
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