using Autofac;
using CoreApp.Ai.IoC.Handlers;

namespace CoreApp.Ai.IoC
{
    public static class IoC
    {
        private static IContainer _container;

        public static void Initialize()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<StartMoveHandler>().Named<ICommandHandler>("StartMove");
            builder.RegisterType<StopMoveHandler>().Named<ICommandHandler>("StopMove");
            builder.RegisterType<StartRotationHandler>().Named<ICommandHandler>("StartRotation");
            builder.RegisterType<StopRotationHandler>().Named<ICommandHandler>("StopRotation");

            _container = builder.Build();
        }

        public static ICommandHandler Resolve(string command)
        {
            return _container.ResolveNamed<ICommandHandler>(command);
        }
    }
}
