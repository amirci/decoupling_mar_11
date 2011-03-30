using Bootstrap;
using Castle.Windsor;
using MavenThought.Commons.WPF.Events;
using Microsoft.Practices.ServiceLocation;

namespace MavenThought.MediaLibrary.Desktop.Tasks
{
    public class RegisterHandlersTask : IStartupTask
    {
        public void Run()
        {
            var container = (IWindsorContainer) Bootstrapper.GetContainer();

            var ea = container.Resolve<IEventAggregator>();

            var subscriptions = EventHandlers
                .From
                .CurrentAssembly()
                .Factory(ServiceLocator.Current);

            ea.Subscribe(subscriptions);
        }

        public void Reset()
        {
        }
    }
}