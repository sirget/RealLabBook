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
    public class BookingsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BookingsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Bookings
        public async Task<IActionResult> Index(int ToolID,string date = "")
        {
            if (date == "")
            {
                date = DateTime.Now.ToString("M-d-yyyy");
            }
            List<Booking> booking = await _context.Bookings.Where(d => d.ToolID.Equals(ToolID) && d.start_time.Contains(date)).ToListAsync();
            List<Tool> tools = await _context.Tools.Where(d => d.ToolID.Equals(ToolID)).ToListAsync();
            int quan = tools[0].Quantity;
            int[] avaliable = { quan, quan, quan, quan, quan, quan, quan, quan };
            foreach(Booking b in booking)
            {
                if(b.start_time == date + " 08:00")
                {
                    avaliable[0]--;
                }
                else if (b.start_time == date + " 09:00")
                {
                    avaliable[1]--;
                }
                else if (b.start_time == date + " 10:00")
                {
                    avaliable[2]--;
                }
                else if (b.start_time == date + " 11:00")
                {
                    avaliable[3]--;
                }
                else if (b.start_time == date + " 12:00")
                {
                    avaliable[4]--;
                }
                else if (b.start_time == date + " 13:00")
                {
                    avaliable[5]--;
                }
                else if (b.start_time == date + " 14:00")
                {
                    avaliable[6]--;
                }
                else if (b.start_time == date + " 15:00")
                {
                    avaliable[7]--;
                }
            }
            List<int> ListQuan = new List<int>();
            for (int i = 0; i < 8; i++)
            {
                ListQuan.Add(avaliable[i]);
            }
            ViewData["ListQuan"] = ListQuan;
            return View(booking);
        }

        // GET: Bookings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var booking = await _context.Bookings
                .FirstOrDefaultAsync(m => m.BookingID == id);
            if (booking == null)
            {
                return NotFound();
            }

            return View(booking);
        }

        // GET: Bookings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Bookings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BookingID,ToolID,UserID,start_time")] Booking booking)
        {
            if (ModelState.IsValid)
            {
                _context.Add(booking);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(booking);
        }

        // GET: Bookings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var booking = await _context.Bookings.FindAsync(id);
            if (booking == null)
            {
                return NotFound();
            }
            return View(booking);
        }

        // POST: Bookings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BookingID,ToolID,UserID,start_time")] Booking booking)
        {
            if (id != booking.BookingID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(booking);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookingExists(booking.BookingID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(booking);
        }

        // GET: Bookings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var booking = await _context.Bookings
                .FirstOrDefaultAsync(m => m.BookingID == id);
            if (booking == null)
            {
                return NotFound();
            }

            return View(booking);
        }

        // POST: Bookings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var booking = await _context.Bookings.FindAsync(id);
            _context.Bookings.Remove(booking);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookingExists(int id)
        {
            return _context.Bookings.Any(e => e.BookingID == id);
        }
    }
}
