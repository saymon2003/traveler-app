using Microsoft.EntityFrameworkCore;

namespace TravelApp.Data
{
    public class TravelContext : DbContext
    {
        public TravelContext(DbContextOptions<TravelContext> options) : base(options) { }

        public DbSet<Traveler> Travelers => Set<Traveler>();
        public DbSet<Destination> Destinations => Set<Destination>();
        public DbSet<TripPlan> TripPlan => Set<TripPlan>(); // ✅ Add this line

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Traveler>(e =>
            {
                e.ToTable("Travelers");
                e.HasKey(t => t.Id);
            });

            mb.Entity<Destination>(e =>
            {
                e.ToTable("Destinations");
                e.HasKey(d => d.DestinationId);
            });

            mb.Entity<TripPlan>(e =>
            {
                e.ToTable("TripPlan");
                e.HasKey(tp => tp.Id);
                e.HasOne(tp => tp.Traveler)
                  .WithMany(t => t.TripPlan)
                  .HasForeignKey(tp => tp.TravelerId);
                e.HasOne(tp => tp.Destination)
                  .WithMany(d => d.TripPlan)
                  .HasForeignKey(tp => tp.DestinationId);
            });
        }
    }
}
