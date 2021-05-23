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
    public class ToolsAPIController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ToolsAPIController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ToolsAPI
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tool>>> GetTools(int limit=5)
        {
            return await _context.Tools.Take(limit).ToListAsync();
        }

        // GET: api/ToolsAPI/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tool>> GetTool(int id)
        {
            var tool = await _context.Tools.FindAsync(id);

            if (tool == null)
            {
                return NotFound();
            }

            return tool;
        }

        // PUT: api/ToolsAPI/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTool(int id, Tool tool)
        {
            if (id != tool.ToolID)
            {
                return BadRequest();
            }

            _context.Entry(tool).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ToolExists(id))
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

        // POST: api/ToolsAPI
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Tool>> PostTool(Tool tool)
        {
            _context.Tools.Add(tool);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTool", new { id = tool.ToolID }, tool);
        }

        // DELETE: api/ToolsAPI/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTool(int id)
        {
            var tool = await _context.Tools.FindAsync(id);
            if (tool == null)
            {
                return NotFound();
            }

            _context.Tools.Remove(tool);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ToolExists(int id)
        {
            return _context.Tools.Any(e => e.ToolID == id);
        }
    }
}
