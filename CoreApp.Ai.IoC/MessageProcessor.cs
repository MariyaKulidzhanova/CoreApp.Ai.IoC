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
