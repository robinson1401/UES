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
    public class HeDaoTaosController : ControllerBase
    {
        private readonly UESContext _context;

        public HeDaoTaosController(UESContext context)
        {
            _context = context;
        }

        // GET: api/HeDaoTaos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HeDaoTao>>> GetHeDaoTao()
        {
          if (_context.HeDaoTao == null)
          {
              return NotFound();
          }
            return await _context.HeDaoTao.ToListAsync();
        }

        // GET: api/HeDaoTaos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HeDaoTao>> GetHeDaoTao(Guid id)
        {
          if (_context.HeDaoTao == null)
          {
              return NotFound();
          }
            var heDaoTao = await _context.HeDaoTao.FindAsync(id);

            if (heDaoTao == null)
            {
                return NotFound();
            }

            return heDaoTao;
        }

        // PUT: api/HeDaoTaos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHeDaoTao(Guid id, HeDaoTao heDaoTao)
        {
            if (id != heDaoTao.Id)
            {
                return BadRequest();
            }

            _context.Entry(heDaoTao).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HeDaoTaoExists(id))
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

        // POST: api/HeDaoTaos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HeDaoTao>> PostHeDaoTao(HeDaoTao heDaoTao)
        {
          if (_context.HeDaoTao == null)
          {
              return Problem("Entity set 'UESContext.HeDaoTao'  is null.");
          }
            _context.HeDaoTao.Add(heDaoTao);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHeDaoTao", new { id = heDaoTao.Id }, heDaoTao);
        }

        // DELETE: api/HeDaoTaos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHeDaoTao(Guid id)
        {
            if (_context.HeDaoTao == null)
            {
                return NotFound();
            }
            var heDaoTao = await _context.HeDaoTao.FindAsync(id);
            if (heDaoTao == null)
            {
                return NotFound();
            }

            _context.HeDaoTao.Remove(heDaoTao);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HeDaoTaoExists(Guid id)
        {
            return (_context.HeDaoTao?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
