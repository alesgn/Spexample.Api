using System.Collections.Generic;

namespace Spektrix.Domain
{
    public static class EventRepository
    {
        public static IEnumerable<Event> GetEvents()
        {
            var events = new List<Event>
            {
                new Event
                {
                    Id = "76308d20-68be-41bc-8ac9-7f6ce2232176",
                    Name = "Hamlet",
                    Description = "One of Shakespeare's longest plays.",
                    Duration = 180,
                    IsOnSale = true
                },
                new Event
                {
                    Id = "3bc93487-2dc9-4326-bff9-55cc24095d8f",
                    Name = "West Side Story",
                    Description = "A musical based on the story of Romeo and Juliet.",
                    Duration = 150,
                    IsOnSale = false
                },
            };

            return events;
        }
    }
}