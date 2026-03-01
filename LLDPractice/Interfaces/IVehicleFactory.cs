using LLDPractice.Models;

namespace LLDPractice.Interfaces
{
    //instead of separate interfaces for IEngine, Istartpolicy etc we can have one common interface for combination of intef reqd. for a vehicle type 
    //Abstract factory 
    public interface IVehicleFactory
    {
        IEngine CreateEngine();
        IStartPolicy CreateStartPolicy();
        Vehicle CreateVehicle(string name);

    }
}