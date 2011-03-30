namespace MavenThought.MediaLibrary.Domain
{
    public interface IMovieCritic
    {
        /// <summary>
        /// Gets the name of the critic
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Gets the critic opinion
        /// </summary>
        /// <param name="movie"></param>
        /// <returns></returns>
        string Review(IMovie movie);
    }
}