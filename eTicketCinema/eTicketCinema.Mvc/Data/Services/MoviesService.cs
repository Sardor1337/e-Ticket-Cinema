using eTicketCinema.Mvc.Data.Base;
using eTicketCinema.Mvc.Models;

namespace eTicketCinema.Mvc.Data.Services
{
    public class MoviesService : EntityBaseRepository<Movie>, IMoviesService
    {
        public MoviesService(AppDbContext dbContext) : base(dbContext) { }

    }
}
