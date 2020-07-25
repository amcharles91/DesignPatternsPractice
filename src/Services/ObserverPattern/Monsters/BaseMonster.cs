using Domain;
using System;

namespace Services
{
    /// <summary>
    /// Base Class for all monsters
    /// </summary>
    public abstract class BaseMonster : ISubscriber
    {
        protected readonly string _monsterName;
        protected readonly int _health;
        private readonly IPublisher _wavePublisher;

        public BaseMonster(IPublisher publisher, string name, int health = 50)
        {
            if (name == null)
                throw new ArgumentNullException(nameof(name));

            if (!(publisher is WavePublisher))
                throw new ArgumentNullException("Can only take use a WavePublisher Type");

            _monsterName = name;
            _health = health;
            _wavePublisher = publisher;

            //Subscribe Monster
            _wavePublisher.Subscribe(this);
        }

        public virtual void SpawnMonster()
        {
            Console.WriteLine($"Spawning {_monsterName}");
        }

        public virtual void StopSpawning()
        {
            _wavePublisher.UnSubscribe(this);
        }

        public virtual void Update(IPublisher publisher)
        {
            if (publisher is IWavePublisher)
            {
                SpawnMonster();
            }
        }
    }
}
