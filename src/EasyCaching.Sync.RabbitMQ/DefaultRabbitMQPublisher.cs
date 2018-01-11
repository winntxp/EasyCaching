﻿namespace EasyCaching.Sync.RabbitMQ
{
    using EasyCaching.Core;
    using EasyCaching.Core.Internal;
    using System;

    /// <summary>
    /// Default RabbitMQ Publisher.
    /// </summary>
    public class DefaultRabbitMQPublisher : IEasyCachingPublisher
    {
        /// <summary>
        /// Notify the specified cacheKey, cacheValue and expiration with notifyType.
        /// </summary>
        /// <param name="notifyType">Notify type.</param>
        /// <param name="cacheKey">Cache key.</param>
        /// <param name="cacheValue">Cache value.</param>
        /// <param name="expiration">Expiration.</param>
        public void Notify(NotifyType notifyType, string cacheKey, object cacheValue, TimeSpan expiration)
        {
            throw new NotImplementedException();
        }
    }
}
