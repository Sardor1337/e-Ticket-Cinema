using eTicketCinema.Mvc.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace eTicketCinema.Mvc.Controllers
{
    public class ProducersController : Controller
    {
        private readonly AppDbContext _dbcontext;

        public ProducersController(AppDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<IActionResult> Index()
        {
            var allProducer = await _dbcontext.Producers.ToListAsync();
            return View( allProducer);
        }
    }
}
