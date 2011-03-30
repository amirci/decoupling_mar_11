using System.Collections.Generic;
using System.Windows;
using MavenThought.Commons.Extensions;

namespace MavenThought.MediaLibrary.Desktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow(IEnumerable<UIElement> children)
        {
            InitializeComponent();

            children.ForEach(c => this._panel.Children.Add(c));
        }
    }
}
