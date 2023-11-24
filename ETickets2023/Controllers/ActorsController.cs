﻿using ETickets2023.Data;
using Microsoft.AspNetCore.Mvc;

namespace ETickets2023.Controllers
{
    public class ActorsController : Controller
    {
        private readonly AppDbContext _context;

        public ActorsController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var allActors = _context.Actors.ToList();

            return View ();
        }
    }
}
