using System.Collections.Generic;
using System.Threading.Tasks;
using LoGo.Data;
using LoGo.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LoGo.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class LogosController : ControllerBase
    {
        private readonly StoreContext _context;
  
        public LogosController(StoreContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Logo>>> GetLogos()
        {
            var logos = await _context.Logos.ToListAsync();

            return Ok(logos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Logo>> GetLogo(int id)
        {
            return await _context.Logos.FindAsync(id);
        }
    }
}