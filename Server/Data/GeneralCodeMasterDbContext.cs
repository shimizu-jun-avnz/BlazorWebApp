using Microsoft.EntityFrameworkCore;
using BlazorWebApp.Shared.Models;

namespace BlazorWebApp.Server.Data
{
    public class GeneralCodeMasterDbContext : DbContext
    {
        public GeneralCodeMasterDbContext(DbContextOptions<GeneralCodeMasterDbContext> options) : base(options)
        {
        }

        public DbSet<General_code_master>? GeneralCodeMaster { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<General_code_master>()
                .HasKey(c => new { c.Code_type, c.Code_id });
        }
    }
}
