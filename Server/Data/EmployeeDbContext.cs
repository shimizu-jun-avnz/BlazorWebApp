using Microsoft.EntityFrameworkCore;
using BlazorWebApp.Shared.Models;

namespace BlazorWebApp.Server.Data
{
    public class EmployeeDbContext : DbContext
    {
        

        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
        {
        }

        public DbSet<Employee>? Employee { get; set; }
        public DbSet<Job_code_master>? Job_code_master { get; set; }
        public DbSet<Division_code_master>? Division_code_master { get; set; }
        public DbSet<Department_code_master>? Department_code_master { get; set; }

    }
}
