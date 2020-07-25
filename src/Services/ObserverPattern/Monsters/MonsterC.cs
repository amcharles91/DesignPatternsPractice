using Domain;

namespace Services
{
    public class MonsterC : BaseMonster
    {
        public MonsterC(IPublisher publisher, string name, int health = 50) : base(publisher, name, health)
        {
        }

        public override void Update(int wave)
        {
            if (wave > 3)
            {
                SpawnMonster();
            }
        }
    }
}
