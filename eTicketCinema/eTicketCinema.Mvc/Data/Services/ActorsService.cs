using eTicketCinema.Mvc.Data.Base;
using eTicketCinema.Mvc.Models;

namespace eTicketCinema.Mvc.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {
        public ActorsService(AppDbContext dbContext) : base(dbContext) { }


    }
}
