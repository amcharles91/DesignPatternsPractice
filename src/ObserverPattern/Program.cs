using Services;
using System;
using System.Threading;

namespace ObserverPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Observer Pattern");

            Console.WriteLine("Creating Publisher");
            var wavePublisher = new WavePublisher();
            Console.WriteLine("Adding Monsters");

            var MonsterA = new MonsterA(wavePublisher, "MonsterA");
            var MonsterA2 = new MonsterA(wavePublisher, "MonsterA2");
            var MonsterB = new MonsterB(wavePublisher, "MonsterB");
            var MonsterC = new MonsterC(wavePublisher, "MonsterC");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Incrementing Wave");
                wavePublisher.NextWave();
                Thread.Sleep(3000);
            }
        }
    }
}
