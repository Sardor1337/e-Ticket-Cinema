using eTicketCinema.Mvc.Models;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eTicketCinema.Mvc.Data.Services
{
    public interface IActorsService
    {
        public Task<IEnumerable<Actor> >GettAllAsync();
        Task<Actor> GettByIdAsync(int id);
        Task AddAsync(Actor actor);
        Task<Actor> UpdateAsync(int id, Actor newActor);
        Task DeleteAsync(int id);

    }
}
