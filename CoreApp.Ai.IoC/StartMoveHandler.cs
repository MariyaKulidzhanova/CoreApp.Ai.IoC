namespace CoreApp.Ai.IoC
{
    public class StartMoveHandler : ICommandHandler
    {
        public void Handle(UObject message)
        {
            if (message.Parameters.TryGetValue("velocity", out int velocity))
            {
                // Начать движение с заданной скоростью
                Console.WriteLine($"Starting movement with velocity {velocity}");
            }
        }
    }
}
