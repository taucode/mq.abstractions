using System.Threading;
using System.Threading.Tasks;

namespace TauCode.Mq.Abstractions
{
    public interface IAsyncMessageHandler
    {
        Task HandleAsync(object message, string topic, CancellationToken cancellationToken);
    }
}
