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
    public class Department_code_masterController : ControllerBase
    {
        private readonly Department_code_masterDbContext _context;

        public Department_code_masterController(Department_code_masterDbContext context)
        {
            _context = context;
        }

        // GET: api/Department_code_master
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Department_code_master>>> GetDepartment_code_master()
        {
            return await _context.Department_code_master.ToListAsync();
        }

        // GET: api/Department_code_master/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Department_code_master>> GetDepartment_code_master(int id)
        {
            var department_code_master = await _context.Department_code_master.FindAsync(id);

            if (department_code_master == null)
            {
                return NotFound();
            }

            return department_code_master;
        }

        // PUT: api/Department_code_master/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDepartment_code_master(int id, Department_code_master department_code_master)
        {
            if (id != department_code_master.Department_id)
            {
                return BadRequest();
            }

            _context.Entry(department_code_master).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Department_code_masterExists(id))
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

        // POST: api/Department_code_master
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Department_code_master>> PostDepartment_code_master(Department_code_master department_code_master)
        {
            _context.Department_code_master.Add(department_code_master);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDepartment_code_master", new { id = department_code_master.Department_id }, department_code_master);
        }

        // DELETE: api/Department_code_master/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDepartment_code_master(int id)
        {
            var department_code_master = await _context.Department_code_master.FindAsync(id);
            if (department_code_master == null)
            {
                return NotFound();
            }

            _context.Department_code_master.Remove(department_code_master);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Department_code_masterExists(int id)
        {
            return _context.Department_code_master.Any(e => e.Department_id == id);
        }
    }
}
