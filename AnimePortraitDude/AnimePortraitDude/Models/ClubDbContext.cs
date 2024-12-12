using Microsoft.EntityFrameworkCore; 

namespace AnimePortraitDude.Models
{
    public class ClubDbContext : DbContext
    {
        public ClubDbContext(DbContextOptions<ClubDbContext> options) : base(options)
        {
        }
        public DbSet<Club> Clubs { get; set; }
    }
}
