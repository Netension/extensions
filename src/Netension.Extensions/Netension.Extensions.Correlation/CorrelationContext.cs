using System;

namespace Netension.Extensions.Correlation
{
    internal class CorrelationContext : ICorrelationAccessor, ICorrelationMutator
    {
        public Guid MessageId { get; set; }
        public Guid CorrelationId { get; set; }
        public Guid CausationId { get; set; }
    }
}
