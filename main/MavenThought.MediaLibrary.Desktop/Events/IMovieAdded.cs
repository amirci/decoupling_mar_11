using MavenThought.Commons.WPF.Events;
using MavenThought.MediaLibrary.Domain;

namespace MavenThought.MediaLibrary.Desktop.Events
{
    /// <summary>
    /// Event that represents the movie has beend added
    /// </summary>
    public interface IMovieAdded : IEvent
    {
        /// <summary>
        /// Gets or sets the movie added
        /// </summary>
        IMovie Movie { get; set; }
    }
}