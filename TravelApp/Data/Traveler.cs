namespace TravelApp.Data
{
    public class Traveler
    {
        public int Id { get; set; }                 // PK
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string Style { get; set; } = "";     // "Budget" | "Luxury" | "Adventure"

        // ✅ Navigation property (needed by PlanTrip + EF relationships)
        public ICollection<TripPlan> TripPlan { get; set; } = new List<TripPlan>();
    }
}
