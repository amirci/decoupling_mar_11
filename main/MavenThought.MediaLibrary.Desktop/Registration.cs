using Bootstrap.WindsorExtension;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using MavenThought.Commons.WPF.Events;
using MavenThought.MediaLibrary.Core;
using MavenThought.MediaLibrary.Desktop.AddMovie;
using MavenThought.MediaLibrary.Desktop.Contents;
using MavenThought.MediaLibrary.Desktop.Poster;
using MavenThought.MediaLibrary.Desktop.Reviews;
using MavenThought.MediaLibrary.Domain;
using Microsoft.Practices.ServiceLocation;

namespace MavenThought.MediaLibrary.Desktop
{
    public class Registration : IWindsorRegistration
    {
        public void Register(IWindsorContainer container)
        {
            container.Register(
                Component
                    .For<IMediaLibrary>()
                    .ImplementedBy<MovieLibrary>(),
                Component
                    .For<IEventAggregator>()
                    .ImplementedBy<EventAggregator>(),
                Component
                    .For<IWindsorContainer>()
                    .Instance(container));

            RegisterViews(container);

            RegisterCritics(container);
        }

        private static void RegisterCritics(IWindsorContainer container)
        {
            var descriptor = AllTypes.FromThisAssembly().BasedOn<IMovieCritic>();

            container.Register(descriptor);
        }

        private static void RegisterViews(IWindsorContainer container)
        {
            container.Register(
                // Add movie
                Component
                    .For<AddMovieViewModel>()
                    .Named("AddViewVM"),
                Component
                    .For<ILibraryView>()
                    .ImplementedBy<AddMovieView>()
                    .Parameters(Parameter
                                    .ForKey("DataContext")
                                    .Eq("${AddViewVM}")),
                // Reviews
                Component
                    .For<ReviewsViewModel>()
                    .Named("ReviewsVM"),
                Component
                    .For<ILibraryView>()
                    .ImplementedBy<ReviewsView>()
                    .Parameters(Parameter
                                    .ForKey("DataContext")
                                    .Eq("${ReviewsVM}")),
                // Poster
                Component
                    .For<PosterViewModel>()
                    .Named("PosterVM"),
                Component
                    .For<ILibraryView>()
                    .ImplementedBy<PosterView>()
                    .Parameters(Parameter
                                    .ForKey("DataContext")
                                    .Eq("${PosterVM}")),
                // Library contents
                Component
                    .For<LibraryContentsViewModel>()
                    .Named("ContentsVM"),
                Component
                    .For<ILibraryView>()
                    .ImplementedBy<LibraryContentsView>()
                    .Parameters(Parameter
                                    .ForKey("DataContext")
                                    .Eq("${ContentsVM}")));
        }
    }
}