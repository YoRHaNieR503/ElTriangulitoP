using System;
using System.Collections.Generic;
using System.Linq;
using ElTriangulitoP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ElTriangulitoP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ElTriangulitoDBContext _context;

        public HomeController(ElTriangulitoDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            

            return View();
        }

        
        public IActionResult Privacy()
        {
            return View();
        }
    }
}