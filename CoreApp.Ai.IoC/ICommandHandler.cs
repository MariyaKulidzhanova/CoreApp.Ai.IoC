namespace CoreApp.Ai.IoC
{
    public interface ICommandHandler
    {
        void Handle(UObject message);
    }

}
