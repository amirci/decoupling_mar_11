using System.Windows;
using Bootstrap;
using MavenThought.MediaLibrary.Desktop.AddMovie;

namespace MavenThought.MediaLibrary.Desktop
{
    public class ShowWindowTask : IStartupTask
    {
        public void Run()
        {
            Application.Current.MainWindow = new MainWindow(new AddMovieView());

            Application.Current.MainWindow.Show();
        }

        public void Reset()
        {
        }
    }
}