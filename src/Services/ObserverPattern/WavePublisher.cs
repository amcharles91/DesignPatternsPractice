using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    /// <summary>
    /// Wave Publisher that notify's every minute
    /// </summary>
    public class WavePublisher : IWavePublisher
    {
        private List<ISubscriber> _subscribers = new List<ISubscriber>();
        private int _wave { get; set; } = 0;

        /// <summary>
        /// Increments the wave
        /// </summary>
        public void NextWave()
        {
            _wave++;
            Console.WriteLine($"Starting Wave {_wave}");
            NotifySubscribers();
        }

        /// <summary>
        /// Notifies all subscribers
        /// </summary>
        public void NotifySubscribers()
        {
            Console.WriteLine("Notifying subscribers");

            foreach (var sub in _subscribers)
            {
                sub.Update(_wave);
            }
        }

        /// <summary>
        /// Adding subscribers
        /// </summary>
        /// <param name="subscriber"></param>
        public void Subscribe(ISubscriber subscriber)
        {
            Console.WriteLine("Adding subscriber");

            _subscribers.Add(subscriber);
        }

        /// <summary>
        /// Removing Subscribers
        /// </summary>
        /// <param name="subscriber"></param>
        public void UnSubscribe(ISubscriber subscriber)
        {
            Console.WriteLine("Removing Subscriber");

            //Test using remove
            _subscribers.Remove(subscriber);
        }
    }
}
