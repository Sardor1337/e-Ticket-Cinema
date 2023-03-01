using eTicketCinema.Mvc.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace eTicketCinema.Mvc.Controllers
{
    public class CinemasController : Controller
    {
        private readonly AppDbContext _dbcontext;

        public CinemasController(AppDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<IActionResult> Index()
        {
            var allCinemas = await _dbcontext.Cinemas.ToListAsync();
            return View(allCinemas);
        }
    }
}
