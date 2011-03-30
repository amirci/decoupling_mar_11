using System;
using System.Windows.Input;
using MavenThought.Commons.WPF.Events;
using MavenThought.MediaLibrary.Core;
using MavenThought.MediaLibrary.Desktop.Events;
using MavenThought.MediaLibrary.Desktop.netfx.System.Windows.Input;
using MavenThought.MediaLibrary.Domain;

namespace MavenThought.MediaLibrary.Desktop.AddMovie
{
    /// <summary>
    /// View model to add movies
    /// </summary>
    public class AddMovieViewModel
    {
        public AddMovieViewModel(IMediaLibrary library, IEventAggregator eventAggregator)
        {
            this.Add = new DelegateCommand(() => AddMovie(library, eventAggregator));
        }

        /// <summary>
        /// Command to get or set the movie
        /// </summary>
        public ICommand Add { get; set; }

        /// <summary>
        /// Gets or sets the title of the movie
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Adds a movie and raises an event
        /// </summary>
        /// <param name="library"></param>
        /// <param name="eventAggregator"></param>
        private void AddMovie(IMediaLibrary library, IEventAggregator eventAggregator)
        {
            var movie = new Movie
                            {
                                Title = this.Title,
                                ReleaseDate = DateTime.Now
                            };

            library.Add(movie);

            eventAggregator.Raise<IMovieAdded>(evt => evt.Movie = movie);
        }
    }
}