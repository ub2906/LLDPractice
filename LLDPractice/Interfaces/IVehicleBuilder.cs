using LLDPractice.Models;

namespace LLDPractice.Interfaces
{
    public interface IVehicleBuilder<T> where T : Vehicle
    {
        IVehicleBuilder<T>SetName(string name);
        IVehicleBuilder<T> SetEngine(IEngine engine);
        IVehicleBuilder<T> SetStartPolicy(IStartPolicy policy);
        T Build();
    }
}