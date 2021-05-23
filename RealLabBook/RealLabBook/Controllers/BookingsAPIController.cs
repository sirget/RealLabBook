using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RealLabBook.Data;
using RealLabBook.Models;

namespace RealLabBook.Controllers
{
    public class BookingsAPIController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public BookingsAPIController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/BookingsAPI
        [Route("~/api/BookingsAPI/{ToolID}")]
        public async Task<int[]> GetBookingsDate(int ToolID)
        {
            string date = DateTime.Now.ToString("M-d-yyyy");
            List<Booking> booking = await _context.Bookings.Where(d => d.ToolID.Equals(ToolID) && d.start_time.Contains(date)).ToListAsync();
            List<Tool> tools = await _context.Tools.Where(d => d.ToolID.Equals(ToolID)).ToListAsync();
            int quan = tools[0].Quantity;
            int[] avaliable = { quan, quan, quan, quan, quan, quan, quan, quan };
            foreach (Booking b in booking)
            {
                if (b.start_time == date + " 08:00")
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
            return avaliable;
        }

        // GET: api/BookingsAPI
        [Route("~/api/BookingsAPI/{ToolID}/{date}")]
        public async Task<int[]> GetBookingsDate(int ToolID,string date)
        {
            List<Booking> booking = await _context.Bookings.Where(d => d.ToolID.Equals(ToolID) && d.start_time.Contains(date)).ToListAsync();
            List<Tool> tools = await _context.Tools.Where(d => d.ToolID.Equals(ToolID)).ToListAsync();
            int quan = tools[0].Quantity;
            int[] avaliable = { quan, quan, quan, quan, quan, quan, quan, quan };
            foreach (Booking b in booking)
            {
                if (b.start_time == date + " 08:00")
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
            return avaliable;
        }

        
    }
}
