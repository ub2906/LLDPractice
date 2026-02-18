using System;
using LLDPractice.Interfaces;

namespace LLDPractice.Models
{
 public abstract class Vehicle
 {
        private readonly IEngine _engine;
        private readonly IStartPolicy _startPolicy;

        public VehicleName Name { get; }
        public VehicleId Id { get; }

        public bool isRunning {get; private set;}

        //constructor - called from main and gets the value for engine and name that will be used throughout
        protected Vehicle(VehicleName name, IEngine engine, IStartPolicy startPolicy){
            Id = VehicleId.Create();
            Name = name?? throw new ArgumentNullException(nameof(name));
            _engine = engine ?? throw new ArgumentNullException(nameof(engine));
            _startPolicy = startPolicy;
            isRunning = false;
        }

        //if we make this abstarct - that would mean vehicle does not have a common impl and every subclass NEEDS to implement a diff start 
        //but we know that IEngine handles start for all vehicles so no abs
        public void Start(){
            if (isRunning)
            {
                throw new InvalidOperationException("Vehicle already running");
            }

            _startPolicy.BeforeStart();
            _engine.Start();
            isRunning = true;
        }

        public void Stop(){
            if (!isRunning)
            {
                throw new InvalidOperationException("Vehicle already stopped");
            }
            _engine.Stop();
            isRunning = false;
        }
    }   
}