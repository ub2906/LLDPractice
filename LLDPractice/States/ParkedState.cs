using System;
using System.Collections.Generic;
using LLDPractice.Interfaces;
using LLDPractice.Models;

namespace LLDPractice.States
{
   public class ParkedState : VehicleStateBase
    {
        public override void Start(Vehicle vehicle)
        {
            vehicle.StartEngine();
            Console.WriteLine($"current state is {vehicle.ParkedState} , now changing to {vehicle.RunningState}");
            vehicle.SetState(vehicle.RunningState);
        }

        public override void Stop(Vehicle vehicle)
        {
            throw new InvalidOperationException("Already parked");
        }

        public override double CalculateFuelConsumptionPerSecond(Vehicle vehicle)
        {
            return 0.0;
        }
    }
}