using Mango.Services.RewardAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace Mango.Services.RewardAPIs.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Rewards> Rewards { get; set; }
    }
}
