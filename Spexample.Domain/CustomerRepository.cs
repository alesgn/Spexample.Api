using System;
using System.Collections.Generic;

namespace Spektrix.Domain
{
    public static class CustomerRepository
    {
        public static IEnumerable<Customer> GetCustomers()
        {
            var customers = new List<Customer>
            {
                new Customer
                {
                    Id = "7e0b5e68-a0ee-40e9-a0f8-40fa5241d3a5",
                    FirstName = "Number1",
                    LastName = "Surname1",
                    DateOfBirth = new DateTime(1981,12,9),
                    Email = "thisistheemail@blabla.com",
                    Addresses = new List<Address>
                    {
                        new Address
                        {
                            Line1 = "dsfdfs"
                        },
                        new Address
                        {
                            Line1 = "gdfgfd"
                        }
                    }
    },
                new Customer
                {
                    Id = "29ea7615-7b61-4c89-810d-0ede6689d31d",
                    FirstName = "Another1",
                    LastName = "SurnameAnother1",
                    DateOfBirth = new DateTime(1981,12,9),
                    Email = "sdfdsf@gmail.com",
                    Addresses = new List<Address>
                    {
                        new Address
                        {
                            Line1 = "hghjgjg"
                        },
                        new Address
                        {
                            Line1 = "ghjhj"
                        }
                    }
                },
            };

            return customers;
        }
    }
}