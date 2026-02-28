namespace LLDPractice.Interfaces
{
    public interface IEngine
    {
        void Start();
        void Stop();
        double FuelConsumptionPerSecond();
    }   
}