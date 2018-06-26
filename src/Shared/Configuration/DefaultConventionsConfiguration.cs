using System;
using NServiceBus;
using NServiceBus.FluentConfiguration.Core;

namespace Shared.Configuration
{
    public class DefaultConventionsConfiguration : IDefaultConventionsConfiguration
    {
        public void ConfigureConventions(ConventionsBuilder conventionsConfiguration)
        {
            conventionsConfiguration.DefiningMessagesAs(t => t.Namespace == "Shared.Messages");
        }
    }
}