using System;
using System.Collections.Generic;
using LLDPractice.Interfaces;
using LLDPractice.Models;

namespace LLDPractice.States
{
    public interface IVehicleState
    {
        void Start(Vehicle vehicle);
        void Stop(Vehicle vehicle);
        double CalculateFuelConsumptionPerSecond(Vehicle vehicle);
    }
}