using System.Threading.Tasks;

namespace TauCode.Mq.Abstractions
{
    public abstract class AsyncMessageHandler<TMessage> : IAsyncMessageHandler<TMessage>
        where TMessage : IMessage
    {
        public abstract Task HandleAsync(TMessage message);

        public Task HandleAsync(object message)
        {
            return this.HandleAsync((TMessage)message);
        }
    }
}
