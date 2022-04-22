using Microsoft.EntityFrameworkCore;
using BlazorWebApp.Shared.Models;

namespace BlazorWebApp.Server.Data
{
    public class Department_code_masterDbContext : DbContext
    {
        public Department_code_masterDbContext(DbContextOptions<Department_code_masterDbContext> options) : base(options)
        {
        }

        public DbSet<Department_code_master>? Department_code_master { get; set; }
    }
}
