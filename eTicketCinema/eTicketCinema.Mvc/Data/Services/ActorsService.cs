using eTicketCinema.Mvc.Data.Base;
using eTicketCinema.Mvc.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eTicketCinema.Mvc.Data.Services
{
    public class ActorsService :EntityBaseRepository<Actor>, IActorsService
    {
        public ActorsService(AppDbContext dbContext):base(dbContext) { }
        
        
    }
}
