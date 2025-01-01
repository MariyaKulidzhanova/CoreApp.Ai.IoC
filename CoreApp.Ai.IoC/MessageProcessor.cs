using CoreApp.Ai.IoC.Handlers;
using CoreApp.Ai.IoC.Models;

namespace CoreApp.Ai.IoC
{
    public class MessageProcessor
    {
        public void ProcessMessage(UObject message)
        {
            ICommandHandler handler = IoC.Resolve(message.Action);
            handler.Handle(message);
        }
    }

}
