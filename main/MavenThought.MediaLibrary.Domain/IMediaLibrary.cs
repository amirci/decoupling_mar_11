using System.Collections.Generic;

namespace MavenThought.MediaLibrary.Domain
{
    /// <summary>
    /// Library of media elements
    /// </summary>
    public interface IMediaLibrary
    {
        /// <summary>
        /// Gets the collection of media
        /// </summary>
        IEnumerable<IMovie> Contents { get; }

        /// <summary>
        /// Adds a new element to the library
        /// </summary>
        /// <param name="movie">New media element to add to the library</param>
        void Add(IMovie movie);

        /// <summary>
        /// Clears the contents of the library
        /// </summary>
        void Clear();
    }
}