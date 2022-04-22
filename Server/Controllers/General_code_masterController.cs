#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BlazorWebApp.Server.Data;
using BlazorWebApp.Shared.Models;

namespace BlazorWebApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class General_code_masterController : ControllerBase
    {
        private readonly General_code_masterDbContext _context;

        public General_code_masterController(General_code_masterDbContext context)
        {
            _context = context;
        }

        // GET: api/General_code_master
        [HttpGet]
        public async Task<ActionResult<IEnumerable<General_code_master>>> GetGeneral_code_master()
        {
            return await _context.General_code_master.ToListAsync();
        }

        // GET: api/General_code_master/5
        [HttpGet("{id}")]
        public async Task<ActionResult<General_code_master>> GetGeneral_code_master(int id)
        {
            var general_code_master = await _context.General_code_master.FindAsync(id);

            if (general_code_master == null)
            {
                return NotFound();
            }

            return general_code_master;
        }

        // PUT: api/General_code_master/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGeneral_code_master(int id, General_code_master general_code_master)
        {
            if (id != general_code_master.Code_type)
            {
                return BadRequest();
            }

            _context.Entry(general_code_master).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!General_code_masterExists(id))
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

        // POST: api/General_code_master
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<General_code_master>> PostGeneral_code_master(General_code_master general_code_master)
        {
            _context.General_code_master.Add(general_code_master);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (General_code_masterExists(general_code_master.Code_type))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetGeneral_code_master", new { id = general_code_master.Code_type }, general_code_master);
        }

        // DELETE: api/General_code_master/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGeneral_code_master(int id)
        {
            var general_code_master = await _context.General_code_master.FindAsync(id);
            if (general_code_master == null)
            {
                return NotFound();
            }

            _context.General_code_master.Remove(general_code_master);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool General_code_masterExists(int id)
        {
            return _context.General_code_master.Any(e => e.Code_type == id);
        }
    }
}
