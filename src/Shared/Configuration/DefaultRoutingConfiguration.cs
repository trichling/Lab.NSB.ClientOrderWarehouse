using System;
using NServiceBus;
using NServiceBus.FluentConfiguration.Core;
using Shared.Messages;

namespace Shared.Configuration
{
    public class DefaultRoutingConfiguration : IDefaultRoutingConfiguration<SqlServerTransport>
    {
        public void ConfigureRouting(RoutingSettings<SqlServerTransport> routingSettings)
        {
            routingSettings.RouteToEndpoint(typeof(PlaceOrder), "Order");
            routingSettings.RouteToEndpoint(typeof(PlaceOrderResult), "Client");
            routingSettings.RouteToEndpoint(typeof(PlaceReservation), "Warehouse");
            routingSettings.RouteToEndpoint(typeof(PlaceReservationResult), "Order");

        }
    }
}