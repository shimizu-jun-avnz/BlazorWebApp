using Microsoft.EntityFrameworkCore;
using BlazorWebApp.Shared.Models;

namespace BlazorWebApp.Server.Data
{
    public class Division_code_masterDbContext : DbContext
    {
        public Division_code_masterDbContext(DbContextOptions<Division_code_masterDbContext> options) : base(options)
        {
        }

        public DbSet<Division_code_master>? Division_code_master { get; set; }
    }
}
