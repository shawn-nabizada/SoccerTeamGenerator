using Microsoft.EntityFrameworkCore;
using SoccerApp.Models;

namespace SoccerApp.Data
{
    public class SoccerContext : DbContext
    {
        public SoccerContext(DbContextOptions<SoccerContext> options) : base(options) { }
        public DbSet<Player> Players { get; set; }
    }
}