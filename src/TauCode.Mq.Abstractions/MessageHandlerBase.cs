using System;

namespace TauCode.Mq.Abstractions
{
    public abstract class MessageHandlerBase<TMessage> : IMessageHandler<TMessage>
        where TMessage : IMessage
    {
        public abstract void Handle(TMessage message, string topic);

        public void Handle(object message, string topic)
        {
            if (message == null)
            {
                throw new ArgumentNullException(nameof(message));
            }

            this.Handle((TMessage)message, topic);
        }
    }
}
