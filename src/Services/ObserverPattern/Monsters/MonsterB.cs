using Domain;

namespace Services
{
    public class MonsterB : BaseMonster
    {
        public MonsterB(IPublisher publisher, string name, int health = 50) : base(publisher, name, health)
        {
        }

        public override void Update(int wave)
        {
            if (wave > 2)
            {
                SpawnMonster();
            }
        }
    }
}
