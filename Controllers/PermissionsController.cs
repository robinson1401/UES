﻿using System;
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
    public class PermissionsController : ControllerBase
    {
        private readonly UESContext _context;

        public PermissionsController(UESContext context)
        {
            _context = context;
        }

        // GET: api/Permissions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Permission>>> GetPermission()
        {
          if (_context.Permission == null)
          {
              return NotFound();
          }
            return await _context.Permission.ToListAsync();
        }

        // GET: api/Permissions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Permission>> GetPermission(Guid id)
        {
          if (_context.Permission == null)
          {
              return NotFound();
          }
            var permission = await _context.Permission.FindAsync(id);

            if (permission == null)
            {
                return NotFound();
            }

            return permission;
        }

        // PUT: api/Permissions/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPermission(Guid id, Permission permission)
        {
            if (id != permission.Id)
            {
                return BadRequest();
            }

            _context.Entry(permission).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PermissionExists(id))
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

        // POST: api/Permissions
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Permission>> PostPermission(Permission permission)
        {
          if (_context.Permission == null)
          {
              return Problem("Entity set 'UESContext.Permission'  is null.");
          }
            _context.Permission.Add(permission);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPermission", new { id = permission.Id }, permission);
        }

        // DELETE: api/Permissions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePermission(Guid id)
        {
            if (_context.Permission == null)
            {
                return NotFound();
            }
            var permission = await _context.Permission.FindAsync(id);
            if (permission == null)
            {
                return NotFound();
            }

            _context.Permission.Remove(permission);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PermissionExists(Guid id)
        {
            return (_context.Permission?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
