using eTicketCinema.Mvc.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Threading.Tasks;

namespace eTicketCinema.Mvc.Controllers
{
    public class ActorsController : Controller
    {
        private readonly AppDbContext _dbcontext;

        public ActorsController(AppDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _dbcontext.Actors.ToListAsync();
            return View(data);
        }
    }
}
