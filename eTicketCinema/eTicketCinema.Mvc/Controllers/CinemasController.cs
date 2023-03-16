﻿using eTicketCinema.Mvc.Data.Services;
using eTicketCinema.Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace eTicketCinema.Mvc.Controllers
{
    public class CinemasController : Controller
    {
        private readonly ICinemasService _service;

        public CinemasController(ICinemasService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var allCinemas = await _service.GetAllAsync();
            return View(allCinemas);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Id,Logo,Name,Description")] Cinema cinema)
        {
            if (!ModelState.IsValid)
            {
                return View(cinema);
            }
            await _service.AddAsync(cinema);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id)
        {
            var cinemaDetail = await _service.GetByIdAsync(id);
            if (cinemaDetail == null)
            {
                return View("Not Found");
            }
            return View(cinemaDetail);
        }

        // get:/Actor/Edit/
        public async Task<IActionResult> Edit(int id)
        {
            var cinemaDetail = await _service.GetByIdAsync(id);
            if (cinemaDetail == null)
            {
                return View("Not Found");
            }
            return View(cinemaDetail);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("FullName", "ProfilePictureURL", "Bio")] Cinema cinema)
        {
            if (!ModelState.IsValid)
            {
                return View(cinema);
            }
            cinema.Id = id;
            await _service.UpdateAsync(id, cinema);
            return RedirectToAction(nameof(Index));
        }

        // Get:/Actor/Delete
        public async Task<IActionResult> Delete(int id)
        {
            var cinemaDetail = await _service.GetByIdAsync(id);
            if (cinemaDetail == null)
            {
                return View("Not Found");
            }
            return View(cinemaDetail);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirm(int id)
        {
            var cinemaDetail = await _service.GetByIdAsync(id);
            if (cinemaDetail == null)
            {
                return View("Not Found");
            }

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
