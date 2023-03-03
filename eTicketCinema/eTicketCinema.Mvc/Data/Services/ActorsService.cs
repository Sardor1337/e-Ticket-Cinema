using eTicketCinema.Mvc.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eTicketCinema.Mvc.Data.Services
{
    public class ActorsService : IActorsService
    {
        private readonly AppDbContext _dbContext;

        public ActorsService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task AddAsync(Actor actor)
        {
            await _dbContext.Actors.AddAsync(actor);
            await _dbContext.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Actor>> GettAllAsync()
        {
            var result = await _dbContext.Actors.ToListAsync();
            return result;
        }

        public async Task<Actor> GettByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Actor Update(int id, Actor newActor)
        {
            throw new System.NotImplementedException();
        }
    }
}
