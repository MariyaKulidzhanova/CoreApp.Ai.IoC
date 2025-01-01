using CoreApp.Ai.IoC;
using CoreApp.Ai.IoC.Models;

class Program
{
    static void Main(string[] args)
    {
        IoC.Initialize();

        var messageProcessor = new MessageProcessor();

        var startMoveMessage = new UObject { Action = "StartMove" };
        startMoveMessage.SetVelocity(10);

        var stopMoveMessage = new UObject { Action = "StopMove" };

        messageProcessor.ProcessMessage(startMoveMessage);
        messageProcessor.ProcessMessage(stopMoveMessage);
    }
}
