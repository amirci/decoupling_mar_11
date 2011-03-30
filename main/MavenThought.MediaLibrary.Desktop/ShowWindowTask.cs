using System.Windows;
using Bootstrap;
using Castle.Windsor;
using MavenThought.MediaLibrary.Desktop.AddMovie;

namespace MavenThought.MediaLibrary.Desktop
{
    public class ShowWindowTask : IStartupTask
    {
        public void Run()
        {
            var container = (IWindsorContainer) Bootstrapper.GetContainer();

            Application.Current.MainWindow = new MainWindow(container.Resolve<AddMovieView>());

            Application.Current.MainWindow.Show();
        }

        public void Reset()
        {
        }
    }
}