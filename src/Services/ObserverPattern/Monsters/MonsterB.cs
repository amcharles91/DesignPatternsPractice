using Domain;

namespace Services
{
    public class MonsterB : BaseMonster
    {
        public MonsterB(IPublisher publisher, string name, int health = 50) : base(publisher, name, health)
        {
        }

        public override void Update(IPublisher publisher)
        {
            if (publisher is WavePublisher)
            {
                if ((publisher as WavePublisher).CurrentWave() > 2)
                {
                    base.Update(publisher);
                }
            }
        }
    }
}
