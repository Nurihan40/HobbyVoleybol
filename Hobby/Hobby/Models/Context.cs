using Microsoft.EntityFrameworkCore;

namespace Hobby.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        // Veritabanı tabloları burada tanımlanır
        public DbSet<Matches> Matches { get; set; }
        public DbSet<DifficultyLevels> Difficulties { get; set; }
        public DbSet<Locations> Locations { get; set; }
        public DbSet<Players> Players { get; set; }
        public DbSet<Referees> Referees { get; set; }
        public DbSet<Registrations> Registrations { get; set; }
    }
}
