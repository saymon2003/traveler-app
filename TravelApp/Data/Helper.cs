namespace TravelApp.Data;

using System.Collections.Generic;

public static class Helper
{
    public static List<Destination> GetDestinations()
    {
        return new List<Destination>
        {
            new Destination { DestinationId = 1, Name = "Bali", ExperienceType = "Beach", CostEstimate = 1400 },
            new Destination { DestinationId = 2, Name = "Kyoto", ExperienceType = "Culture", CostEstimate = 1600 },
            new Destination { DestinationId = 3, Name = "Banff", ExperienceType = "Nature", CostEstimate = 1200 },
            new Destination { DestinationId = 4, Name = "Paris", ExperienceType = "City", CostEstimate = 2000 },
            new Destination { DestinationId = 5, Name = "Machu Picchu", ExperienceType = "Nature", CostEstimate = 1700 },
            new Destination { DestinationId = 6, Name = "Lisbon", ExperienceType = "Culture", CostEstimate = 1300 },
            new Destination { DestinationId = 7, Name = "Reykjavik", ExperienceType = "Nature", CostEstimate = 1800 },
            new Destination { DestinationId = 8, Name = "Cancún", ExperienceType = "Beach", CostEstimate = 1100 },
            new Destination { DestinationId = 9, Name = "Tokyo", ExperienceType = "City", CostEstimate = 1900 },
            new Destination { DestinationId = 10, Name = "Barcelona", ExperienceType = "Culture", CostEstimate = 1500 }
        };
    }
}