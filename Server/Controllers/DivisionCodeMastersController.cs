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
    public class DivisionCodeMastersController : ControllerBase
    {
        private readonly DivisionCodeMasterDbContext _context;

        public DivisionCodeMastersController(DivisionCodeMasterDbContext context)
        {
            _context = context;
        }

        // GET: api/DivisionCodeMasters
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Division_code_master>>> GetDivisionCodeMaster()
        {
            return await _context.DivisionCodeMaster.ToListAsync();
        }

        // GET: api/DivisionCodeMasters/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Division_code_master>> GetDivisionCodeMaster(int id)
        {
            var divisionCodeMaster = await _context.DivisionCodeMaster.FindAsync(id);

            if (divisionCodeMaster == null)
            {
                return NotFound();
            }

            return divisionCodeMaster;
        }

        // PUT: api/DivisionCodeMasters/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDivisionCodeMaster(int id, Division_code_master divisionCodeMaster)
        {
            if (id != divisionCodeMaster.Division_id)
            {
                return BadRequest();
            }

            _context.Entry(divisionCodeMaster).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DivisionCodeMasterExists(id))
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

        // POST: api/DivisionCodeMasters
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Division_code_master>> PostDivisionCodeMaster(Division_code_master divisionCodeMaster)
        {
            _context.DivisionCodeMaster.Add(divisionCodeMaster);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDivisionCodeMaster", new { id = divisionCodeMaster.Division_id }, divisionCodeMaster);
        }

        // DELETE: api/DivisionCodeMasters/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDivisionCodeMaster(int id)
        {
            var divisionCodeMaster = await _context.DivisionCodeMaster.FindAsync(id);
            if (divisionCodeMaster == null)
            {
                return NotFound();
            }

            _context.DivisionCodeMaster.Remove(divisionCodeMaster);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DivisionCodeMasterExists(int id)
        {
            return _context.DivisionCodeMaster.Any(e => e.Division_id == id);
        }
    }
}
