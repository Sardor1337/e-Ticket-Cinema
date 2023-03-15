using eTicketCinema.Mvc.Data.Base;
using eTicketCinema.Mvc.Models;

namespace eTicketCinema.Mvc.Data.Services
{
    public class CinemasService : EntityBaseRepository<Cinema>, ICinemasService
    {
        public CinemasService(AppDbContext dbContext) : base(dbContext) { }

    }
}
