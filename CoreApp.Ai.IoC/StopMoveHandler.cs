namespace CoreApp.Ai.IoC
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
