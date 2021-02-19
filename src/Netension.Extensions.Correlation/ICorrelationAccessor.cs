using System;

namespace Netension.Extensions.Correlation
{
    public interface ICorrelationAccessor
    {
        Guid? MessageId { get; }
        Guid CorrelationId { get; }
        Guid? CausationId { get; }
    }
}
