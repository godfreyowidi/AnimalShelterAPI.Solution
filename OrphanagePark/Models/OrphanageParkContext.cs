using Microsoft.EntityFrameworkCore;

namespace OrphanagePark.Models
{
    public class OrphanageParkContext : DbContext
    {
        public OrphanageParkContext(DbContextOptions<OrphanageParkContext> options)
            : base(options)
        {
        }

        public DbSet<Animal> Animals { get; set; }
    }
}