using System.Windows;
using Bootstrap;
using Bootstrap.WindsorExtension;
using MavenThought.MediaLibrary.Desktop.AddMovie;

namespace MavenThought.MediaLibrary.Desktop
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App 
    {
        /// <summary>
        /// Run the bootstrapper
        /// </summary>
        /// <param name="e"></param>
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            Bootstrapper
                .With
                .Container(new WindsorContainerExtension())
                .Start();
        }
    }
}
