using System;
using LLDPractice.Interfaces;

namespace LLDPractice.Models
{
    public class Car : Vehicle
    {
        public Car(string name, IEngine engine)
            : base(name, engine)
        {

        }
    }
}