using System;
using NServiceBus;
using NServiceBus.FluentConfiguration.Core;
using NServiceBus.Transport.SQLServer;

namespace Shared.Configuration
{
    public class DefaultTransportConfiguration : IDefaultTransportConfiguration<SqlServerTransport>
    {
        public static string ConnectionString = "Server=.;Database=NSBMessaging;Trusted_Connection=True;MultipleActiveResultSets=true";


        public void ConfigureTransport(NServiceBus.TransportExtensions<SqlServerTransport> transport)
        {
            transport.ConnectionString(ConnectionString);
            transport.UseSchemaForQueue("error", "dbo");
            transport.UseSchemaForQueue("audit", "dbo");
            transport.UseSchemaForEndpoint("Client", "client");
            transport.UseSchemaForEndpoint("Order", "Order");
            transport.UseSchemaForEndpoint("Warehouse", "Warehouse");
            transport.Transactions(TransportTransactionMode.SendsAtomicWithReceive);
        }
    }
}