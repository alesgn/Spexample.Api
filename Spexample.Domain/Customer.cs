using System;
using System.Collections.Generic;

namespace Spektrix.Domain
{
    public class Customer
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Email { get; set; }
        public IEnumerable<Address> Addresses { get; set; }

        public Customer()
        {
            Addresses = Addresses ?? new List<Address>();
        }
    }

    public class Address
    {
        public string Line1 { get; set; }
    }
}
