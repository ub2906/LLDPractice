using System;
using LLDPractice.Interfaces;

namespace LLDPractice.Models
{
 public abstract class Vehicle
 {
        private readonly IEngine _engine;

        public string Name {get; }

        //constructor - called from main and gets the value for engine and name that will be used throughout
        protected Vehicle(string name, IEngine engine){
            Name = name;
            _engine = engine;
        }

        //if we make this abstarct - that would mean vehicle does not have a common impl and every subclass NEEDS to implement a diff start 
        //but we know that IEngine handles start for all vehicles so no abs
        public void Start(){
            _engine.Start();
        }

        public void Stop(){
            _engine.Stop();
        }
    }   
}