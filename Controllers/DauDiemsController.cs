﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UES.Data;
using UES.Interfaces;
using UES.Models;
using UES.Services.Dto;

namespace UES.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DauDiemsController : ControllerBase
    {
        private readonly UESContext _context;
        private readonly DauDiemServiec _dauDiemRepository;
        private readonly IMapper _mapper;

        public DauDiemsController(UESContext context, DauDiemServiec dauDiemRepository, IMapper mapper)
        {
            _context = context;
            _dauDiemRepository = dauDiemRepository;
            _mapper = mapper;
        }

        // GET: api/DauDiems
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<DauDiem>>> GetDauDiem()
        //{
        //    //if (_context.DauDiem == null)
        //    //{
        //    //    return NotFound();
        //    //}
        //    //  return await _context.DauDiem.Include(h => h.HocPhan).ToListAsync();
        //    var daudiems = _dauDiemRepository.GetDauDiem;
        //    if (_context.DauDiem == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(daudiems);
        //}
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<DauDiem>))]
        public IActionResult GetDauDiem()
        {
            var daudiems = _mapper.Map<List<DauDiemDto>>(_dauDiemRepository.GetDauDiems());
            if (_context.DauDiem == null)
            {
                return NotFound();
            }
            return Ok(daudiems);

        }
        // GET: api/DauDiems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DauDiem>> GetDauDiem(Guid id)
        {
          if (_context.DauDiem == null)
          {
              return NotFound();
          }
            var dauDiem = _context.DauDiem
                .Include(h => h.HocPhan)
                .Where(d => d.Id == id)
                .FirstOrDefault();

            if (dauDiem == null)
            {
                return NotFound();
            }

            return dauDiem;
        }

        // PUT: api/DauDiems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDauDiem(Guid id, DauDiem dauDiem)
        {
            if (id != dauDiem.Id)
            {
                return BadRequest();
            }

            _context.Entry(dauDiem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DauDiemExists(id))
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

        // POST: api/DauDiems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DauDiem>> PostDauDiem(DauDiem dauDiem)
        {
          if (_context.DauDiem == null)
          {
              return Problem("Entity set 'UESContext.DauDiem'  is null.");
          }
            _context.DauDiem.Add(dauDiem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDauDiem", new { id = dauDiem.Id }, dauDiem);
        }

        // DELETE: api/DauDiems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDauDiem(Guid id)
        {
            if (_context.DauDiem == null)
            {
                return NotFound();
            }
            var dauDiem = await _context.DauDiem.FindAsync(id);
            if (dauDiem == null)
            {
                return NotFound();
            }

            _context.DauDiem.Remove(dauDiem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DauDiemExists(Guid id)
        {
            return (_context.DauDiem?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
