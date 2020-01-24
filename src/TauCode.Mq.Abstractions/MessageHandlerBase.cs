using System;

namespace TauCode.Mq.Abstractions
{
    public abstract class MessageHandlerBase<TMessage> : IMessageHandler<TMessage>
        where TMessage : IMessage
    {
        public abstract void Handle(TMessage message);

        public void Handle(object message)
        {
            if (message == null)
            {
                throw new ArgumentNullException(nameof(message));
            }

            this.Handle((TMessage)message);
        }
    }
}
