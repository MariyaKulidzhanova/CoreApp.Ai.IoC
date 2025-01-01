using CoreApp.Ai.IoC.Models;

namespace CoreApp.Ai.IoC.Handlers
{
    public class StopRotationHandler : ICommandHandler
    {
        public void Handle(UObject message)
        {
            // Прекратить вращение
            Console.WriteLine("Stopping rotation");
        }
    }
}
