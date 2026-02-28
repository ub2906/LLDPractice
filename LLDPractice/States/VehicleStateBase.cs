using System;
using System.Collections.Generic;
using LLDPractice.Interfaces;
using LLDPractice.Models;

namespace LLDPractice.States
{
    public abstract class VehicleStateBase : IVehicleState
    {
        public virtual void Start(Vehicle vehicle)
            => throw new InvalidOperationException("Operation not allowed in current state.");

        public virtual void Stop(Vehicle vehicle)
            => throw new InvalidOperationException("Operation not allowed in current state.");

        public virtual double CalculateFuelConsumptionPerSecond(Vehicle vehicle)
            => throw new InvalidOperationException("Operation not allowed in current state.");
    }
}