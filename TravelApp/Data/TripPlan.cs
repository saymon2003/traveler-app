namespace TravelApp.Data
{
    public class TripPlan
    {
        public int Id { get; set; }
        public int TravelerId { get; set; }
        public int DestinationId { get; set; }

        public Traveler? Traveler { get; set; }
        public Destination? Destination { get; set; }
    }
}
