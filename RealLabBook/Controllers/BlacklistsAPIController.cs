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
    [Route("api/[controller]")]
    [ApiController]
    public class BlacklistsAPIController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public BlacklistsAPIController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/BlacklistsAPI
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Blacklist>>> GetBlacklists()
        {
            return await _context.Blacklists.ToListAsync();
        }

        // GET: api/BlacklistsAPI/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Blacklist>> GetBlacklist(string id)
        {
            var blacklist = await _context.Blacklists.FindAsync(id);

            if (blacklist == null)
            {
                return NotFound();
            }

            return blacklist;
        }

        // PUT: api/BlacklistsAPI/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBlacklist(string id, Blacklist blacklist)
        {
            if (id != blacklist.UserID)
            {
                return BadRequest();
            }

            _context.Entry(blacklist).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BlacklistExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/BlacklistsAPI
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Blacklist>> PostBlacklist(Blacklist blacklist)
        {
            _context.Blacklists.Add(blacklist);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (BlacklistExists(blacklist.UserID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetBlacklist", new { id = blacklist.UserID }, blacklist);
        }

        // DELETE: api/BlacklistsAPI/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBlacklist(string id)
        {
            var blacklist = await _context.Blacklists.FindAsync(id);
            if (blacklist == null)
            {
                return NotFound();
            }

            _context.Blacklists.Remove(blacklist);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BlacklistExists(string id)
        {
            return _context.Blacklists.Any(e => e.UserID == id);
        }
    }
}
