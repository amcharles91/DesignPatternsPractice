using Domain;

namespace Services
{
    public class MonsterC : BaseMonster
    {
        public MonsterC(IPublisher publisher, string name, int health = 50) : base(publisher, name, health)
        {
        }

        public override void Update(IPublisher publisher)
        {
            if (publisher is WavePublisher)
            {
                if ((publisher as WavePublisher).CurrentWave() > 3)
                {
                    base.Update(publisher);
                }
            }
        }
    }
}
