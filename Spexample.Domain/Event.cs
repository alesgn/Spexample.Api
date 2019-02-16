using System;

namespace Spektrix.Domain
{
    public class Event
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }
        public bool IsOnSale { get; set; }
    }
}