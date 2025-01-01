using CoreApp.Ai.IoC.Models;

namespace CoreApp.Ai.IoC.Handlers
{
    public interface ICommandHandler
    {
        void Handle(UObject message);
    }

}
