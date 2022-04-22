using BlazorWebApp.Shared.Models;
using Microsoft.EntityFrameworkCore;
namespace BlazorWebApp.Server.Data
{
    public class Job_code_masterDbContext : DbContext
    {
        public Job_code_masterDbContext(DbContextOptions<Job_code_masterDbContext> options) : base(options)
        {
        }

        public DbSet<Job_code_master>? Job_code_master { get; set; }
    }

}
