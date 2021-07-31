using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ZeroToHeroService.Models.CustomerAddresses;
using ZeroToHeroService.Models.Customers;

namespace ZeroToHeroService.Models.Addresses
{
    public class Address
    {
        public Guid Id { get; set; }
        public string Town { get; set; }
        public string Street { get; set; }  
        public int HouseNumber { get; set; } 
        public int ZipCode { get; set; }

        [JsonIgnore]
        public IEnumerable<CustomerAddress> CustomerAddresses { get; set; }
    }
}
