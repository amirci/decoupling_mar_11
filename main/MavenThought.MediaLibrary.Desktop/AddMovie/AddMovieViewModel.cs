using System.Windows;
using System.Windows.Input;
using MavenThought.Commons.WPF.Events;
using MavenThought.MediaLibrary.Domain;

namespace MavenThought.MediaLibrary.Desktop.AddMovie
{
    public class AddMovieViewModel
    {
        private readonly IMediaLibrary _library;
        private readonly IEventAggregator _eventAggregator;

        public AddMovieViewModel(IMediaLibrary library, IEventAggregator eventAggregator)
        {
            _library = library;
            _eventAggregator = eventAggregator;

            this.Add = new DelegateCommand(() => MessageBox.Show("Executed! with " + this.Title));
        }

        /// <summary>
        /// Command to get or set the movie
        /// </summary>
        public ICommand Add { get; set; }

        /// <summary>
        /// Gets or sets the title of the movie
        /// </summary>
        public string Title { get; set; }
    }
}