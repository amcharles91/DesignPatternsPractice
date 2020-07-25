namespace Domain
{
    /// <summary>
    /// Publisher that provides the data for all subscribers
    /// </summary>
    public interface IPublisher
    {
        /// <summary>
        /// Add's a new subscriber to publish changes too
        /// </summary>
        /// <param name="subscriber"></param>
        void Subscribe(ISubscriber subscriber);

        /// <summary>
        /// Remove a subscriber
        /// </summary>
        /// <param name="subscriber"></param>
        void UnSubscribe(ISubscriber subscriber);

        /// <summary>
        /// Notify's all subscribers with new updates
        /// </summary>
        /// <param name="subscriber"></param>
        void NotifySubscribers();
    }
}
