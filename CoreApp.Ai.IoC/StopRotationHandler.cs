namespace CoreApp.Ai.IoC
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
