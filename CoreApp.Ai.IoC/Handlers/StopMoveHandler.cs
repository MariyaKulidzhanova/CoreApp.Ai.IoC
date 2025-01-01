using CoreApp.Ai.IoC.Models;

namespace CoreApp.Ai.IoC.Handlers
{
    public class StopMoveHandler : ICommandHandler
    {
        public void Handle(UObject message)
        {
            // Прекратить прямолинейное движение
            Console.WriteLine("Stopping movement");
        }
    }
}
