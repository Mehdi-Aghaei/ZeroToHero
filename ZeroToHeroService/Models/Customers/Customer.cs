using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ZeroToHeroService.Models.Addresses;
using ZeroToHeroService.Models.CustomerRentals;
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
        public IEnumerable<Address> Addresses { get; set; }
        [JsonIgnore]
        public IEnumerable<CustomerRental> CustomerRentals { get; set; }

    }
}
