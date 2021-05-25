using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RealLabBook.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RealLabBook.Controllers
{
    public class accessdeniedController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public accessdeniedController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}