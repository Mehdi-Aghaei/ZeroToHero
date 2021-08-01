using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using ZeroToHeroService.Models.CustomerAddresses;
using ZeroToHeroService.Models.Rentals;


namespace ZeroToHeroService.Models.Customers
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTimeOffset BirthDay { get; set; }
        public Gender Gender { get; set; }

        [JsonIgnore]
        public IEnumerable<CustomerAddress> CustomerAddresses { get; set; }
        [JsonIgnore]
        public IEnumerable<Rental> CustomerRentals { get; set; }

    }
}
