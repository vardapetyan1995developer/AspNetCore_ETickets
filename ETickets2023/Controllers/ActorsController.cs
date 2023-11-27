using ETickets2023.Data;
using ETickets2023.Data.Services;
using ETickets2023.Models;
using Microsoft.AspNetCore.Mvc;

namespace ETickets2023.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _service;

        public ActorsController(IActorsService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAll();

            return View (data);
        }

        public IActionResult Create() 
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,ProfilePictureUrl,Bio")]Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }

            _service.Add(actor);

            return RedirectToAction(nameof(Index));
        }
    }
}
