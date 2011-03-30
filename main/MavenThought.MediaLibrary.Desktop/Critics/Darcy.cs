using MavenThought.MediaLibrary.Domain;

namespace MavenThought.MediaLibrary.Desktop.Critics
{
    /// <summary>
    /// Needs more Bacon
    /// </summary>
    public class Darcy : IMovieCritic
    {
        /// <summary>
        /// Gets the name of the critic
        /// </summary>
        public string Name
        {
            get { return "D'Arcy Lussier"; }
        }

        /// <summary>
        /// Gets the critic opinion
        /// </summary>
        /// <param name="movie"></param>
        /// <returns></returns>
        public string Review(IMovie movie)
        {
            var result = "Needs more Bacon!";

            if (movie.Title.ToLower().IndexOf("bacon") > 0)
            {
                result = "Awesome movie! Loved the Bacon part!";    
            }
            
            return result;
        }
    }
}