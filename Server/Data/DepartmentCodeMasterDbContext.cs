using Microsoft.EntityFrameworkCore;
using BlazorWebApp.Shared.Models;

namespace BlazorWebApp.Server.Data
{
    public class DepartmentCodeMasterDbContext : DbContext
    {
        public DepartmentCodeMasterDbContext(DbContextOptions<DepartmentCodeMasterDbContext> options) : base(options)
        {
        }

        public DbSet<Department_code_master>? DepartmentCodeMaster { get; set; }
    }
}
