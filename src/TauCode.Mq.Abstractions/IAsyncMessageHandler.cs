using System.Threading.Tasks;

namespace TauCode.Mq.Abstractions
{
    public interface IAsyncMessageHandler
    {
        Task HandleAsync(object message);
    }
}
