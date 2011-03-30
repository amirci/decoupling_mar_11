using System.Linq;
using System.Text;
using Castle.Windsor;
using MavenThought.Commons.Events;
using MavenThought.Commons.WPF.Events;
using MavenThought.MediaLibrary.Desktop.Events;
using MavenThought.MediaLibrary.Domain;

namespace MavenThought.MediaLibrary.Desktop.Reviews
{
    /// <summary>
    /// Shows the reviews of all the critics
    /// </summary>
    public class ReviewsViewModel : AbstractNotifyPropertyChanged, IHandleEventsOfType<IMovieAdded> 
    {
        /// <summary>
        /// Critics to use
        /// </summary>
        private readonly IMovieCritic[] _critics;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="container"></param>
        public ReviewsViewModel(IWindsorContainer container)
            : this()
        {
            this._critics = container.ResolveAll<IMovieCritic>();
        }

        public ReviewsViewModel()
        {
            this.Reviews = "Reviews not available";
        }

        /// <summary>
        /// Gets or sets the reviews
        /// </summary>
        public string Reviews { get; set; }

        /// <summary>
        /// Show the reviews for the movies
        /// </summary>
        /// <param name="event">Event for the movie</param>
        public void Handle(IMovieAdded @event)
        {
            var movie = @event.Movie;

            this.Reviews = "Sorry, no reviews available";

            this.Reviews = this._critics
                .Aggregate(new StringBuilder(), (builder, critic) => CriticReview(builder, critic, movie))
                .ToString();

            this.OnPropertyChanged(() => Reviews);
        }

        /// <summary>
        /// Generate the review
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="critic"></param>
        /// <param name="movie"></param>
        /// <returns></returns>
        private static StringBuilder CriticReview(StringBuilder builder, IMovieCritic critic, IMovie movie)
        {
            const string CriticOpinion = "{0} says on {1}: {2}";

            return builder
                .AppendFormat(CriticOpinion, critic.Name, movie.Title, critic.Review(movie))
                .AppendLine();
        }
    }
}