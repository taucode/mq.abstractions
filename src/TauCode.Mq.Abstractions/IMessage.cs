using System;

namespace TauCode.Mq.Abstractions
{
    public interface IMessage
    {
        string CorrelationId { get; }
        DateTime CreatedAt { get; }
    }
}
