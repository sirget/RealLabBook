using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RealLabBook.Data;
using RealLabBook.Models;
using Microsoft.AspNetCore.Cors;

namespace RealLabBook.Controllers
{

    public class ToolsAPIController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ToolsAPIController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ToolsAPI?limit=?
        [EnableCors("AllowAny")]
        [Route("~/api/ToolsAPI")]
        public async Task<ActionResult<IEnumerable<Tool>>> GetToolslimit(int limit = 5)
        {
            return await _context.Tools.Take(limit).ToListAsync();
        }

        [EnableCors("AllowAny")]
        [Route("~/api/ToolsAPI/{id}")]
        public async Task<ActionResult<Tool>> GetToolsid(int id)
        {
            return await _context.Tools.FindAsync(id);
        }

    }
}
