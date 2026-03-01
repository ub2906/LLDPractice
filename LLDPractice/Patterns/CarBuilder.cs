using LLDPractice.Interfaces;
using LLDPractice.Models;
using System;
using System.Collections.Generic;

namespace LLDPractice.Patterns
{
    public class CarBuilder : IVehicleBuilder<Car>
    {
        private VehicleName _name;
        private IEngine _engine;
        private IStartPolicy _policy;

        public IVehicleBuilder<Car> SetName(string name)
        {
            _name = VehicleName.Create(name);
            return this;
        }

        public IVehicleBuilder<Car> SetEngine(IEngine engine)
        {
            _engine = engine;
            return this;
        }

        public IVehicleBuilder<Car> SetStartPolicy(IStartPolicy policy)
        {
            _policy = policy;
            return this;
        }

        public Car Build()
        {
            if (_name == null || _engine == null || _policy == null)
                throw new InvalidOperationException("Vehicle incomplete");

            return new Car(_name, _engine, _policy);
        }
    }
}