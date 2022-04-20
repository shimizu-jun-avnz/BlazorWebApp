using Microsoft.EntityFrameworkCore;
using BlazorWebApp.Shared.Models;

namespace BlazorWebApp.Server.Data
{
    public class DivisionCodeMasterDbContext : DbContext
    {
        public DivisionCodeMasterDbContext(DbContextOptions<DivisionCodeMasterDbContext> options) : base(options)
        {
        }

        public DbSet<Division_code_master>? DivisionCodeMaster { get; set; }
    }
}
