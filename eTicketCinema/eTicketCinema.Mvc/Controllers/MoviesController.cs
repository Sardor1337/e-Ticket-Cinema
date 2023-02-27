using eTicketCinema.Mvc.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace eTicketCinema.Mvc.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDbContext _dbcontext;
        public MoviesController(AppDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<IActionResult> Index()
        {
            var allPMovies = await _dbcontext.Movies.ToListAsync();
            return View();
        }
    }
}
