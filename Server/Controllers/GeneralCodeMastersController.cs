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
    public class GeneralCodeMastersController : ControllerBase
    {
        private readonly GeneralCodeMasterDbContext _context;

        public GeneralCodeMastersController(GeneralCodeMasterDbContext context)
        {
            _context = context;
        }

        // GET: api/GeneralCodeMasters
        [HttpGet]
        public async Task<ActionResult<IEnumerable<General_code_master>>> GetGeneralCodeMaster()
        {
            return await _context.GeneralCodeMaster.ToListAsync();
        }

        // GET: api/GeneralCodeMasters/5
        [HttpGet("{id}")]
        public async Task<ActionResult<General_code_master>> GetGeneralCodeMaster(int id)
        {
            var generalCodeMaster = await _context.GeneralCodeMaster.FindAsync(id);

            if (generalCodeMaster == null)
            {
                return NotFound();
            }

            return generalCodeMaster;
        }

        // PUT: api/GeneralCodeMasters/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGeneralCodeMaster(int id, General_code_master generalCodeMaster)
        {
            if (id != generalCodeMaster.Code_type)
            {
                return BadRequest();
            }

            _context.Entry(generalCodeMaster).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GeneralCodeMasterExists(id))
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

        // POST: api/GeneralCodeMasters
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<General_code_master>> PostGeneralCodeMaster(General_code_master generalCodeMaster)
        {
            _context.GeneralCodeMaster.Add(generalCodeMaster);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (GeneralCodeMasterExists(generalCodeMaster.Code_type))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetGeneralCodeMaster", new { id = generalCodeMaster.Code_type }, generalCodeMaster);
        }

        // DELETE: api/GeneralCodeMasters/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGeneralCodeMaster(int id)
        {
            var generalCodeMaster = await _context.GeneralCodeMaster.FindAsync(id);
            if (generalCodeMaster == null)
            {
                return NotFound();
            }

            _context.GeneralCodeMaster.Remove(generalCodeMaster);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool GeneralCodeMasterExists(int id)
        {
            return _context.GeneralCodeMaster.Any(e => e.Code_type == id);
        }
    }
}
