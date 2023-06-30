using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UES.Data;
using UES.Models;

namespace UES.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NganhsController : ControllerBase
    {
        private readonly UESContext _context;

        public NganhsController(UESContext context)
        {
            _context = context;
        }

        // GET: api/Nganhs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Nganh>>> GetNganh()
        {
          if (_context.Nganh == null)
          {
              return NotFound();
          }
            return await _context.Nganh.ToListAsync();
        }

        // GET: api/Nganhs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Nganh>> GetNganh(Guid id)
        {
          if (_context.Nganh == null)
          {
              return NotFound();
          }
            var nganh = await _context.Nganh.FindAsync(id);

            if (nganh == null)
            {
                return NotFound();
            }

            return nganh;
        }

        // PUT: api/Nganhs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNganh(Guid id, Nganh nganh)
        {
            if (id != nganh.Id)
            {
                return BadRequest();
            }

            _context.Entry(nganh).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NganhExists(id))
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

        // POST: api/Nganhs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Nganh>> PostNganh(Nganh nganh)
        {
          if (_context.Nganh == null)
          {
              return Problem("Entity set 'UESContext.Nganh'  is null.");
          }
            _context.Nganh.Add(nganh);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetNganh", new { id = nganh.Id }, nganh);
        }

        // DELETE: api/Nganhs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNganh(Guid id)
        {
            if (_context.Nganh == null)
            {
                return NotFound();
            }
            var nganh = await _context.Nganh.FindAsync(id);
            if (nganh == null)
            {
                return NotFound();
            }

            _context.Nganh.Remove(nganh);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool NganhExists(Guid id)
        {
            return (_context.Nganh?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
