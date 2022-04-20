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
    public class DepartmentCodeMastersController : ControllerBase
    {
        private readonly DepartmentCodeMasterDbContext _context;

        public DepartmentCodeMastersController(DepartmentCodeMasterDbContext context)
        {
            _context = context;
        }

        // GET: api/DepartmentCodeMasters
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Department_code_master>>> GetDepartmentCodeMaster()
        {
            return await _context.DepartmentCodeMaster.ToListAsync();
        }

        // GET: api/DepartmentCodeMasters/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Department_code_master>> GetDepartmentCodeMaster(int id)
        {
            var departmentCodeMaster = await _context.DepartmentCodeMaster.FindAsync(id);

            if (departmentCodeMaster == null)
            {
                return NotFound();
            }

            return departmentCodeMaster;
        }

        // PUT: api/DepartmentCodeMasters/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDepartmentCodeMaster(int id, Department_code_master departmentCodeMaster)
        {
            if (id != departmentCodeMaster.Department_id)
            {
                return BadRequest();
            }

            _context.Entry(departmentCodeMaster).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DepartmentCodeMasterExists(id))
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

        // POST: api/DepartmentCodeMasters
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Department_code_master>> PostDepartmentCodeMaster(Department_code_master departmentCodeMaster)
        {
            _context.DepartmentCodeMaster.Add(departmentCodeMaster);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDepartmentCodeMaster", new { id = departmentCodeMaster.Department_id }, departmentCodeMaster);
        }

        // DELETE: api/DepartmentCodeMasters/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDepartmentCodeMaster(int id)
        {
            var departmentCodeMaster = await _context.DepartmentCodeMaster.FindAsync(id);
            if (departmentCodeMaster == null)
            {
                return NotFound();
            }

            _context.DepartmentCodeMaster.Remove(departmentCodeMaster);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DepartmentCodeMasterExists(int id)
        {
            return _context.DepartmentCodeMaster.Any(e => e.Department_id == id);
        }
    }
}
