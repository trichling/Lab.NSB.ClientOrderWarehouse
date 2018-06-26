using System;
using NServiceBus;
using NServiceBus.FluentConfiguration.Core;

namespace Shared.Configuration
{
    public class DefaultEndpointConfiguration : IDefaultEndpointConfiguration
    {
        public void ConfigureEndpoint(EndpointConfiguration endpointConfiguration)
        {
            endpointConfiguration.SendFailedMessagesTo("error");
            endpointConfiguration.AuditProcessedMessagesTo("audit");
            endpointConfiguration.EnableInstallers();
        }
    }
}