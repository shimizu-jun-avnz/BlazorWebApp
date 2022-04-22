using Microsoft.EntityFrameworkCore;
using BlazorWebApp.Shared.Models;

namespace BlazorWebApp.Server.Data
{
    public class General_code_masterDbContext : DbContext
    {
        public General_code_masterDbContext(DbContextOptions<General_code_masterDbContext> options) : base(options)
        {
        }

        public DbSet<General_code_master>? General_code_master { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<General_code_master>()
                .HasKey(c => new { c.Code_type, c.Code_id });
        }
    }
}
