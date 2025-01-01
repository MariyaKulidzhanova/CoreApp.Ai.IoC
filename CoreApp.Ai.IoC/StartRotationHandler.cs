namespace CoreApp.Ai.IoC
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
