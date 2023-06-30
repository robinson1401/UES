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
    public class ChuongTrinhDaoTaosController : ControllerBase
    {
        private readonly UESContext _context;

        public ChuongTrinhDaoTaosController(UESContext context)
        {
            _context = context;
        }

        // GET: api/ChuongTrinhDaoTaos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ChuongTrinhDaoTao>>> GetChuongTrinhDaoTao()
        {
          if (_context.ChuongTrinhDaoTao == null)
          {
              return NotFound();
          }
            return await _context.ChuongTrinhDaoTao.ToListAsync();
        }

        // GET: api/ChuongTrinhDaoTaos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ChuongTrinhDaoTao>> GetChuongTrinhDaoTao(Guid id)
        {
          if (_context.ChuongTrinhDaoTao == null)
          {
              return NotFound();
          }
            var chuongTrinhDaoTao = await _context.ChuongTrinhDaoTao.FindAsync(id);

            if (chuongTrinhDaoTao == null)
            {
                return NotFound();
            }

            return chuongTrinhDaoTao;
        }

        // PUT: api/ChuongTrinhDaoTaos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutChuongTrinhDaoTao(Guid id, ChuongTrinhDaoTao chuongTrinhDaoTao)
        {
            if (id != chuongTrinhDaoTao.Id)
            {
                return BadRequest();
            }

            _context.Entry(chuongTrinhDaoTao).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChuongTrinhDaoTaoExists(id))
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

        // POST: api/ChuongTrinhDaoTaos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ChuongTrinhDaoTao>> PostChuongTrinhDaoTao(ChuongTrinhDaoTao chuongTrinhDaoTao)
        {
          if (_context.ChuongTrinhDaoTao == null)
          {
              return Problem("Entity set 'UESContext.ChuongTrinhDaoTao'  is null.");
          }
            _context.ChuongTrinhDaoTao.Add(chuongTrinhDaoTao);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetChuongTrinhDaoTao", new { id = chuongTrinhDaoTao.Id }, chuongTrinhDaoTao);
        }

        // DELETE: api/ChuongTrinhDaoTaos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteChuongTrinhDaoTao(Guid id)
        {
            if (_context.ChuongTrinhDaoTao == null)
            {
                return NotFound();
            }
            var chuongTrinhDaoTao = await _context.ChuongTrinhDaoTao.FindAsync(id);
            if (chuongTrinhDaoTao == null)
            {
                return NotFound();
            }

            _context.ChuongTrinhDaoTao.Remove(chuongTrinhDaoTao);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ChuongTrinhDaoTaoExists(Guid id)
        {
            return (_context.ChuongTrinhDaoTao?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
