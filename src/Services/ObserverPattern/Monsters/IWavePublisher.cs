using Domain;

namespace Services
{
    public interface IWavePublisher : IPublisher
    {
        int CurrentWave();
    }
}
