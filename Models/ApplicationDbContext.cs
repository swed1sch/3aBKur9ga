using Microsoft.EntityFrameworkCore;


namespace SmokeTube.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Pokur>Pokurs{ get; set; }
        public DbSet<Member> Members { get; set; }
    }
}
