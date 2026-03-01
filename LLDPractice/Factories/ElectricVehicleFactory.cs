using LLDPractice.Interfaces;
using LLDPractice.Models;

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
            var engine = CreateEngine();
            var policy = CreateStartPolicy();
            return new Car(VehicleName.Create(name), engine, policy);
        }
    }
}