using Domain;
using System;

namespace Services
{
    public class MonsterA : BaseMonster
    {
        public MonsterA(IPublisher publisher, string name, int health = 50) : base(publisher, name, health)
        {
        }

        public override void Update(IPublisher publisher)
        {
            if (publisher is IWavePublisher)
            {
                var currentWave = (publisher as IWavePublisher).CurrentWave();
                if (currentWave >= 1 && currentWave < 3)
                {
                    base.Update(publisher);
                }
            }
        }
    }
}
