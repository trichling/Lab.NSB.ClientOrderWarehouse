using System;
using System.Data.SqlClient;
using NServiceBus;
using NServiceBus.FluentConfiguration.Core;
using NServiceBus.Persistence.Sql;

namespace Shared.Configuration
{
    public class DefaultPersistenceConfiguration : IDefaultPersistenceConfiguration<SqlPersistence>
    {
        public void ConfigurePersistence(NServiceBus.PersistenceExtensions<SqlPersistence> persistenceConfiguration)
        {
            persistenceConfiguration.ConnectionBuilder(() => new SqlConnection(DefaultTransportConfiguration.ConnectionString));

            var dialect = persistenceConfiguration.SqlDialect<SqlDialect.MsSqlServer>();
            var subscriptions = persistenceConfiguration.SubscriptionSettings();
            subscriptions.CacheFor(TimeSpan.FromMinutes(1));
        }
    }
}