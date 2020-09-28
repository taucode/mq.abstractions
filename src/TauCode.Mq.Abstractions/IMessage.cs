using System;

namespace TauCode.Mq.Abstractions
{
    public interface IMessage
    {
        string CorrelationId { get; set; }
        DateTimeOffset CreatedAt { get; set; }
    }
}
