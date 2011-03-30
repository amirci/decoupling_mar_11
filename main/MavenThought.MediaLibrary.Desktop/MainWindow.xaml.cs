using System.Windows;

namespace MavenThought.MediaLibrary.Desktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow(UIElement addMovies)
        {
            InitializeComponent();

            this._panel.Children.Add(addMovies);
        }
    }
}
