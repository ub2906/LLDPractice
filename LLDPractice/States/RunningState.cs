using System;
using System.Collections.Generic;
using LLDPractice.Interfaces;
using LLDPractice.Models;

namespace LLDPractice.States
{
    public class RunningState : VehicleStateBase
    {
        public override void Start(Vehicle vehicle)
        {
            throw new InvalidOperationException("Already running");
        }

        public override void Stop(Vehicle vehicle)
        {
            vehicle.StopEngine();
            Console.WriteLine($"current state is {vehicle.RunningState} , now changing to {vehicle.ParkedState}");
            vehicle.SetState(vehicle.ParkedState);
        }

        public override double CalculateFuelConsumptionPerSecond(Vehicle vehicle)
        {
           var baseVal = vehicle.GetEngineFuelConsumption();
           return baseVal;
        }
    }
}