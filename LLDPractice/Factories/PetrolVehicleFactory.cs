using LLDPractice.Interfaces;
using LLDPractice.Models;

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
            var engine = CreateEngine();
            var policy = CreateStartPolicy();
            return new Car(VehicleName.Create(name), engine, policy);
        }
    }
}