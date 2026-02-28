using System;
using LLDPractice.Interfaces;
using LLDPractice.States;

namespace LLDPractice.Models
{
 public abstract class Vehicle
 {
        private readonly IEngine _engine;
        private readonly IStartPolicy _startPolicy;
        private IVehicleState _currentState;

        private readonly IVehicleState _parkedState;
        private readonly IVehicleState _runningState;
        private readonly IVehicleState _brokenState;

        public VehicleName Name { get; }
        public VehicleId Id { get; }

        //public bool isRunning {get; private set;}

        //constructor - called from main and gets the value for engine and name that will be used throughout
        protected Vehicle(VehicleName name, IEngine engine, IStartPolicy startPolicy){
            Id = VehicleId.Create();
            Name = name?? throw new ArgumentNullException(nameof(name));
            _engine = engine ?? throw new ArgumentNullException(nameof(engine));
            _startPolicy = startPolicy;
            //isRunning = false;
            _parkedState = new ParkedState();
            _runningState = new RunningState();
            _brokenState = new BrokenState();
            _currentState = _parkedState;
        }

        //public accessors =>
        public IVehicleState ParkedState => _parkedState;
        public IVehicleState RunningState => _runningState;

        public IVehicleState BrokenState => _brokenState;

        public void SetState(IVehicleState state)
        {
            _currentState = state ?? throw new ArgumentNullException(nameof(state));
        }

        public void Start()
        {
            _currentState.Start(this);
        }

        public void Stop()
        {
            _currentState.Stop(this);
        }

        public double FuelConsumptionPerSecond()
        {
            return _currentState.CalculateFuelConsumptionPerSecond(this);
        }

        public double GetEngineFuelConsumption()
        {
            return _engine.FuelConsumptionPerSecond();
        }

        //if we make this abstarct - that would mean vehicle does not have a common impl and every subclass NEEDS to implement a diff start 
        //but we know that IEngine handles start for all vehicles so no abs

        // THIS IS NOW WRONG as soon as we add state - start method should NOT maintain code for state change and engine start/stop
        // public void Start(){
        //     // if (isRunning)
        //     // {
        //     //     throw new InvalidOperationException("Vehicle already running");
        //     // }
        //     _currentState.Start(this);

        //     _startPolicy.BeforeStart();
        //     _engine.Start();
        //     //isRunning = true;
        // }

        // public void Stop(){
        //     // if (!isRunning)
        //     // {
        //     //     throw new InvalidOperationException("Vehicle already stopped");
        //     // }
        //      _currentState.Stop(this);
        //     _engine.Stop();
        //     //isRunning = false;
        // }

         public void StartEngine()
        {
            _startPolicy.BeforeStart();
            _engine.Start();
        }

        public void StopEngine()
        {
            _engine.Stop();
        }
    }   
}