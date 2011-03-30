using System.IO;
using MavenThought.Commons.Events;
using MavenThought.Commons.WPF.Events;
using MavenThought.MediaLibrary.Desktop.Events;

namespace MavenThought.MediaLibrary.Desktop.Poster
{
    /// <summary>
    /// View model for posters
    /// </summary>
    public class PosterViewModel : AbstractNotifyPropertyChanged, IHandleEventsOfType<IMovieAdded>
    {
        public PosterViewModel()
        {
            this.Poster = "../images/_blank.bmp";
        }

        /// <summary>
        /// Gets or sets the poster of the movie
        /// </summary>
        public string Poster { get; set; }

        /// <summary>
        /// Find the poster for the movie
        /// </summary>
        /// <param name="event"></param>
        public void Handle(IMovieAdded @event)
        {
            var title = string.Format("images/{0}.jpg", @event
                                                           .Movie
                                                           .Title
                                                           .Trim()
                                                           .ToLower()
                                                           .Replace(" ", string.Empty));

            if (!File.Exists(title))
            {
                title = "images/_blank.bmp";
            }

            this.Poster = string.Format("../{0}", title);
            
            this.OnPropertyChanged(() => Poster);
        }
    }
}