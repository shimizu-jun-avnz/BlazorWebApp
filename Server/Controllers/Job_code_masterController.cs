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
    public class Job_code_masterController : ControllerBase
    {
        private readonly Job_code_masterDbContext _context;

        public Job_code_masterController(Job_code_masterDbContext context)
        {
            _context = context;
        }

        // GET: api/Job_code_master
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Job_code_master>>> GetJob_code_master()
        {
            return await _context.Job_code_master.ToListAsync();
        }

        // GET: api/Job_code_master/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Job_code_master>> GetJob_code_master(int id)
        {
            var job_code_master = await _context.Job_code_master.FindAsync(id);

            if (job_code_master == null)
            {
                return NotFound();
            }

            return job_code_master;
        }

        // PUT: api/Job_code_master/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJob_code_master(int id, Job_code_master job_code_master)
        {
            if (id != job_code_master.Job_id)
            {
                return BadRequest();
            }

            _context.Entry(job_code_master).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Job_code_masterExists(id))
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

        // POST: api/Job_code_master
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Job_code_master>> PostJob_code_master(Job_code_master job_code_master)
        {
            _context.Job_code_master.Add(job_code_master);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetJob_code_master", new { id = job_code_master.Job_id }, job_code_master);
        }

        // DELETE: api/Job_code_master/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJob_code_master(int id)
        {
            var job_code_master = await _context.Job_code_master.FindAsync(id);
            if (job_code_master == null)
            {
                return NotFound();
            }

            _context.Job_code_master.Remove(job_code_master);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Job_code_masterExists(int id)
        {
            return _context.Job_code_master.Any(e => e.Job_id == id);
        }
    }
}
