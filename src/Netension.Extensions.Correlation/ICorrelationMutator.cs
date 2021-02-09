using System;

namespace Netension.Extensions.Correlation
{
    public interface ICorrelationMutator
    {
        Guid MessageId { set; }
        Guid? CorrelationId { set; }
        Guid? CausationId { set; }
    }
}
