namespace TravelApp.Data
{
    public class Destination
    {
        public int DestinationId { get; set; }
        public string Name { get; set; } = "";
        public string ExperienceType { get; set; } = ""; // Beach, Culture, Nature, City
        public double CostEstimate { get; set; }

        public ICollection<TripPlan> TripPlans { get; set; } = new List<TripPlan>();
    }
}
