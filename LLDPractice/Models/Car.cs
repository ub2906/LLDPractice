using System;
using LLDPractice.Interfaces;

namespace LLDPractice.Models
{
    public class Car : Vehicle
    {
        public Car(VehicleName name, IEngine engine)
            : base(name, engine)
        {

        }
    }
}