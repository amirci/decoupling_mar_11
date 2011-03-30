using System.Linq;
using System.Windows;
using Bootstrap;
using Castle.Windsor;

namespace MavenThought.MediaLibrary.Desktop.Tasks
{
    public class ShowWindowTask : IStartupTask
    {
        public void Run()
        {
            var container = (IWindsorContainer) Bootstrapper.GetContainer();

            var children = container.ResolveAll<ILibraryView>().Cast<UIElement>();

            Application.Current.MainWindow = new MainWindow(children);

            Application.Current.MainWindow.Show();
        }

        public void Reset()
        {
        }
    }
}