using System;
using System.Threading.Tasks;

namespace TauCode.Mq.Abstractions
{
    public abstract class MessageHandlerBase<TMessage> : IMessageHandler<TMessage>
        where TMessage : IMessage
    {
        public abstract void Handle(TMessage message);

        public abstract Task HandleAsync(TMessage message);

        public void Handle(object message)
        {
            if (message == null)
            {
                throw new ArgumentNullException(nameof(message));
            }

            this.Handle((TMessage)message);
        }

        public Task HandleAsync(object message)
        {
            if (message == null)
            {
                throw new ArgumentNullException(nameof(message));
            }

            return this.HandleAsync((TMessage)message);
        }
    }
}
