namespace TravelApp.Data
{
    public class Destination
    {
        public int DestinationId { get; set; }
        public string Name { get; set; } = "";
        public string ExperienceType { get; set; } = "";
        public double CostEstimate { get; set; }

        // ✅ Navigation property
        public ICollection<TripPlan> TripPlan { get; set; } = new List<TripPlan>();
    }
}
