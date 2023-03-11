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

        public async Task DeleteAsync(int id)
        {
            var result = await _dbContext.Actors.FirstOrDefaultAsync(x => x.Id == id);
            _dbContext.Remove(result);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Actor>> GettAllAsync()
        {
            var result = await _dbContext.Actors.ToListAsync();
            return result;
        }

        public async Task<Actor> GettByIdAsync(int id)
        {
            var result = await _dbContext.Actors.FirstOrDefaultAsync(x => x.Id == id);
            return result;
        }

        public async Task<Actor> UpdateAsync(int id, Actor newActor)
        {
            _dbContext.Update(newActor);
            await _dbContext.SaveChangesAsync();
            return newActor;
        }
    }
}
