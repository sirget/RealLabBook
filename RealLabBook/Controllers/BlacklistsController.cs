using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RealLabBook.Data;
using RealLabBook.Models;
using Microsoft.AspNetCore.Authorization;

namespace RealLabBook.Controllers
{
    [Authorize(Roles = "Admin")]
    public class BlacklistsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BlacklistsController(ApplicationDbContext context)
        {
            _context = context;
        }
        
        // GET: Blacklists
        public async Task<IActionResult> Index()
        {
            return View(await _context.User.ToListAsync());
        }

        // GET: Blacklists/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blacklist = await _context.Blacklists
                .FirstOrDefaultAsync(m => m.UserID == id);
            if (blacklist == null)
            {
                return NotFound();
            }

            return View(blacklist);
        }

        // GET: Blacklists/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Blacklists/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserID")] Blacklist blacklist)
        {
            if (ModelState.IsValid)
            {
                _context.Add(blacklist);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(blacklist);
        }

        // GET: Blacklists/Edit/5
        public async Task<IActionResult> Edit(Guid id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var user = await _context.User.FindAsync(id);
            return View(user);
        }

        // POST: Blacklists/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit([Bind("id,password,status,name,surname,email,role")] User user)
        {



          
                _context.Update(user);
                await _context.SaveChangesAsync();
            
            return RedirectToAction("Index", "Blacklists");

        }

        // GET: Blacklists/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blacklist = await _context.Blacklists
                .FirstOrDefaultAsync(m => m.UserID == id);
            if (blacklist == null)
            {
                return NotFound();
            }

            return View(blacklist);
        }

        // POST: Blacklists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var blacklist = await _context.Blacklists.FindAsync(id);
            _context.Blacklists.Remove(blacklist);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BlacklistExists(string id)
        {
            return _context.Blacklists.Any(e => e.UserID == id);
        }
    }
}
