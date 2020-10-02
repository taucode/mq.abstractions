using System.Threading;
using System.Threading.Tasks;

namespace TauCode.Mq.Abstractions
{
    public abstract class AsyncMessageHandlerBase<TMessage> : IAsyncMessageHandler<TMessage>
        where TMessage : IMessage
    {
        public abstract Task HandleAsync(TMessage message, string topic, CancellationToken cancellationToken);

        public Task HandleAsync(object message, string topic, CancellationToken cancellationToken)
        {
            return this.HandleAsync((TMessage)message, topic, cancellationToken);
        }
    }
}
