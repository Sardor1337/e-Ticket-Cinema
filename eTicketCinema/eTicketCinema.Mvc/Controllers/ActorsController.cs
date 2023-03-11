using eTicketCinema.Mvc.Data;
using eTicketCinema.Mvc.Data.Services;
using eTicketCinema.Mvc.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Threading.Tasks;

namespace eTicketCinema.Mvc.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _service;

        public ActorsController(IActorsService actorsService)
        {
            _service = actorsService;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _service.GettAllAsync();
            return View(data);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName", "ProfilePictureURL", "Bio")] Actor actor)
        {
            if(!ModelState.IsValid)
            {
                return View(actor);
            }
            await _service.AddAsync(actor);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id)
        {
            var actorDetail = await _service.GettByIdAsync(id);
            if(actorDetail == null)
            {
                return View("Not Found");
            }
            return View(actorDetail);
        }

        // get:/Actor/Edit/
        public async Task<IActionResult> Edit(int id)
        {
            var actorDetail = await _service.GettByIdAsync(id);
            if (actorDetail == null)
            {
                return View("Not Found");
            }
            return View(actorDetail);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("FullName", "ProfilePictureURL", "Bio")] Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            actor.Id = id;
            await _service.UpdateAsync(id, actor);
            return RedirectToAction(nameof(Index));
        }

        // Get:/Actor/Delete
        public async Task<IActionResult> Delete(int id)
        {
            var actorDetail = await _service.GettByIdAsync(id);
            if (actorDetail == null)
            {
                return View("Not Found");
            }
            return View(actorDetail);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirm(int id)
        {
            var actorDetail = await _service.GettByIdAsync(id);
            if (actorDetail == null)
            {
                return View("Not Found");
            }

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
