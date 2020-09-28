using System.Threading.Tasks;

namespace TauCode.Mq.Abstractions
{
    public interface IMessageHandler<in TMessage> : IMessageHandler
        where TMessage : IMessage
    {
        void Handle(TMessage message);

        Task HandleAsync(TMessage message);
    }
}
