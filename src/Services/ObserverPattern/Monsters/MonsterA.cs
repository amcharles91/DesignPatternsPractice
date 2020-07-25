using Domain;
using System;

namespace Services
{
    public class MonsterA : BaseMonster
    {
        public MonsterA(IPublisher publisher, string name, int health = 50) : base(publisher, name, health)
        {
        }

        public override void Update(int wave)
        {
            if (wave >= 1 && wave < 3)
            {
                SpawnMonster();
            }
        }
    }
}
