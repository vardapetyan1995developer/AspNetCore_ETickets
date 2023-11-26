using ETickets2023.Data;
using ETickets2023.Data.Services;
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
    }
}
