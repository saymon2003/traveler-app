using Microsoft.EntityFrameworkCore;

namespace TravelApp.Data
{
    public class TravelContext : DbContext
    {
        public TravelContext(DbContextOptions<TravelContext> options) : base(options) { }

        public DbSet<Traveler> Travelers => Set<Traveler>();
        public DbSet<Destination> Destinations => Set<Destination>();
        public DbSet<TripPlan> TripPlans => Set<TripPlan>();

        protected override void OnModelCreating(ModelBuilder b)
        {
            b.Entity<Traveler>().ToTable("Travelers").HasKey(t => t.Id);
            b.Entity<Destination>().ToTable("Destinations").HasKey(d => d.DestinationId);
            b.Entity<TripPlan>().ToTable("TripPlan").HasKey(tp => tp.Id);

            b.Entity<TripPlan>()
                .HasOne(tp => tp.Traveler)
                .WithMany(t => t.TripPlans)
                .HasForeignKey(tp => tp.TravelerId);

            b.Entity<TripPlan>()
                .HasOne(tp => tp.Destination)
                .WithMany(d => d.TripPlans)
                .HasForeignKey(tp => tp.DestinationId);
        }
    }
}
