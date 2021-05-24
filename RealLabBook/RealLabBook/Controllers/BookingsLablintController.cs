using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RealLabBook.Data;
using RealLabBook.Models;

namespace RealLabBook.Controllers
{
    public class BookingsLablintController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BookingsLablintController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: BookingsLablint
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
