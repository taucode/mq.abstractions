using System.Threading.Tasks;

namespace TauCode.Mq.Abstractions
{
    public interface IAsyncMessageHandler<in TMessage> : IAsyncMessageHandler
        where TMessage : IMessage
    {
        Task HandleAsync(TMessage message);
    }
}
