using System.Collections.Generic;
using MavenThought.MediaLibrary.Domain;

namespace MavenThought.MediaLibrary.Core
{
    /// <summary>
    /// Simple movie library implementation
    /// </summary>
    public class MovieLibrary : IMediaLibrary
    {
        private readonly ICollection<IMovie> _contents;

        public MovieLibrary()
        {
            this._contents = new List<IMovie>();
        }

        /// <summary>
        /// Gets the collection of media
        /// </summary>
        public IEnumerable<IMovie> Contents
        {
            get { return this._contents; }
        }

        /// <summary>
        /// Adds a new element to the library
        /// </summary>
        /// <param name="movie">New media element to add to the library</param>
        public void Add(IMovie movie)
        {
            this._contents.Add(movie);
        }

        /// <summary>
        /// Clears the contents of the library
        /// </summary>
        public void Clear()
        {
            this._contents.Clear();
        }
    }
}