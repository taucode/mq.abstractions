using System.Threading.Tasks;

namespace TauCode.Mq.Abstractions
{
    public interface IMessageHandler
    {
        void Handle(object message);
        Task HandleAsync(object message);
    }
}
