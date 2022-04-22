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
    public class Division_code_masterController : ControllerBase
    {
        private readonly Division_code_masterDbContext _context;

        public Division_code_masterController(Division_code_masterDbContext context)
        {
            _context = context;
        }

        // GET: api/Division_code_master
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Division_code_master>>> GetDivision_code_master()
        {
            return await _context.Division_code_master.ToListAsync();
        }

        // GET: api/Division_code_master/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Division_code_master>> GetDivision_code_master(int id)
        {
            var division_code_master = await _context.Division_code_master.FindAsync(id);

            if (division_code_master == null)
            {
                return NotFound();
            }

            return division_code_master;
        }

        // PUT: api/Division_code_master/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDivision_code_master(int id, Division_code_master division_code_master)
        {
            if (id != division_code_master.Division_id)
            {
                return BadRequest();
            }

            _context.Entry(division_code_master).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Division_code_masterExists(id))
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

        // POST: api/Division_code_master
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Division_code_master>> PostDivision_code_master(Division_code_master division_code_master)
        {
            _context.Division_code_master.Add(division_code_master);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDivision_code_master", new { id = division_code_master.Division_id }, division_code_master);
        }

        // DELETE: api/Division_code_master/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDivision_code_master(int id)
        {
            var division_code_master = await _context.Division_code_master.FindAsync(id);
            if (division_code_master == null)
            {
                return NotFound();
            }

            _context.Division_code_master.Remove(division_code_master);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Division_code_masterExists(int id)
        {
            return _context.Division_code_master.Any(e => e.Division_id == id);
        }
    }
}
