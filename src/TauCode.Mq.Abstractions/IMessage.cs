using System;

namespace TauCode.Mq.Abstractions
{
    public interface IMessage
    {
        string CorrelationId { get; set; }
        DateTime CreatedAt { get; set; }
    }
}
