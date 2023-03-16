using eTicketCinema.Mvc.Data.Base;
using eTicketCinema.Mvc.Models;

namespace eTicketCinema.Mvc.Data.Services
{
    public class ProducersService : EntityBaseRepository<Producer>, IProducersService
    {
        public ProducersService(AppDbContext dbContext) : base(dbContext) { }

    }
}
