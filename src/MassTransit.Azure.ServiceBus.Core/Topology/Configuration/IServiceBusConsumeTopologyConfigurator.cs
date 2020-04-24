﻿namespace MassTransit.Azure.ServiceBus.Core.Topology
{
    using System;
    using MassTransit.Topology;


    public interface IServiceBusConsumeTopologyConfigurator :
        IConsumeTopologyConfigurator,
        IServiceBusConsumeTopology
    {
        new IServiceBusMessageConsumeTopologyConfigurator<T> GetMessageTopology<T>()
            where T : class;

        void AddSpecification(IServiceBusConsumeTopologySpecification specification);

        /// <summary>
        /// Create a topic subscription on the endpoint
        /// </summary>
        /// <param name="topicName">The topic name</param>
        /// <param name="subscriptionName">The name for the subscription</param>
        /// <param name="callback">Configure the exchange and binding</param>
        void Subscribe(string topicName, string subscriptionName, Action<ISubscriptionConfigurator> callback = null);
    }
}
