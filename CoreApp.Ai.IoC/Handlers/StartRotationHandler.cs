using CoreApp.Ai.IoC.Models;

namespace CoreApp.Ai.IoC.Handlers
{
    public class StartRotationHandler : ICommandHandler
    {
        public void Handle(UObject message)
        {
            if (message.Parameters.TryGetValue("angularVelocity", out int angularVelocity))
            {
                // Начать вращение с заданной угловой скоростью
                Console.WriteLine($"Starting rotation with angular velocity {angularVelocity}");
            }
        }
    }
}
