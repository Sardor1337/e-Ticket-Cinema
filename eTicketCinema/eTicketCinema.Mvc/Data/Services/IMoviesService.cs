using eTicketCinema.Mvc.Data.Base;
using eTicketCinema.Mvc.Models;

namespace eTicketCinema.Mvc.Data.Services
{
    public interface IMoviesService : IEntityBaseRepository<Movie>
    {
    }
}
