namespace Domain
{
    /// <summary>
    /// Subscriber(Observer) where values changes based on the publisher update
    /// </summary>
    public interface ISubscriber
    {
        /// <summary>
        /// Whatever you want the Publisher to provide on updates
        /// </summary>
        void Update(IPublisher publisher);
    }
}
