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
    public class ToolsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ToolsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Tools
        public async Task<IActionResult> Index()
        {
            List<Tool> tools = await _context.Tools.ToListAsync();
            int[] quan = { tools[0].Quantity, tools[1].Quantity, tools[2].Quantity, tools[3].Quantity, tools[4].Quantity, };
            List<int> ListQuan = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                ListQuan.Add(quan[i]);
            }
            ViewData["ListQuan"] = ListQuan;
            return View(await _context.Tools.ToListAsync());
        }

        // GET: Tools/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tool = await _context.Tools
                .FirstOrDefaultAsync(m => m.ToolID == id);
            if (tool == null)
            {
                return NotFound();
            }

            return View(tool);
        }

        public async Task<IActionResult> List()
        {

            List<Tool> tools = await _context.Tools.ToListAsync();

            return View(tools);
        }


        [Authorize(Roles = "Admin")]
        // GET: Tools/Create
        public IActionResult Create()
        {
            return View();
        }
        [Authorize(Roles = "Admin")]
        // POST: Tools/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ToolID,Toolname,Quantity")] Tool tool)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tool);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tool);
        }
        [Authorize(Roles = "Admin")]
        // GET: Tools/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tool = await _context.Tools.FindAsync(id);
            if (tool == null)
            {
                return NotFound();
            }
            return View(tool);
        }
        [Authorize(Roles = "Admin")]
        // POST: Tools/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ToolID,Toolname,Quantity")] Tool tool)
        {
            if (id != tool.ToolID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tool);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ToolExists(tool.ToolID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(List));
            }
            return View(tool);
        }
        [Authorize(Roles = "Admin")]
        // GET: Tools/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tool = await _context.Tools
                .FirstOrDefaultAsync(m => m.ToolID == id);
            if (tool == null)
            {
                return NotFound();
            }

            return View(tool);
        }
        [Authorize(Roles = "Admin")]
        // POST: Tools/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tool = await _context.Tools.FindAsync(id);
            _context.Tools.Remove(tool);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ToolExists(int id)
        {
            return _context.Tools.Any(e => e.ToolID == id);
        }
    }
}
