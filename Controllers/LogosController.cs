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

        [HttpPost]
        public ActionResult<Logo> PostDevice(Logo logo)
        {
            _context.Logos.Add(logo);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetLogo), new { id = logo.Id }, logo);
        }

        [HttpPut("{id}")]
        public IActionResult PutLogo(int id, Logo logo)
        {
            if (id!= logo.Id)
            {
                return BadRequest();
            }
            _context.Logo.Update(logo);
            _context.SaveChanges();

            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteLogo(int id)
        {
            var Logo = _context.Logos.Find(id);

            if (Device == null)
            {
                return NotFound();
            }

            _context.Devices.Remove(Device);
            _context.SaveChanges();

            return NoContent();
        }
    }
}