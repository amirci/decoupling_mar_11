using MavenThought.MediaLibrary.Domain;

namespace MavenThought.MediaLibrary.Desktop.Critics
{
    /// <summary>
    /// It stinks!
    /// </summary>
    public class JaySherman : IMovieCritic
    {
        /// <summary>
        /// Gets the name of the critic
        /// </summary>
        public string Name
        {
            get { return "Jay Sherman"; }
        }

        /// <summary>
        /// Gets the critic opinion
        /// </summary>
        /// <param name="movie"></param>
        /// <returns></returns>
        public string Review(IMovie movie)
        {
            return "It stinks!!!";
        }
    }
}