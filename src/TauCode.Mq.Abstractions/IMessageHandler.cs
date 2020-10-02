namespace TauCode.Mq.Abstractions
{
    public interface IMessageHandler
    {
        void Handle(object message, string topic);
    }
}
