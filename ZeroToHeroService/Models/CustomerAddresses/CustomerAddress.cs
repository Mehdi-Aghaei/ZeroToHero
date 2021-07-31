using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZeroToHeroService.Models.Addresses;
using ZeroToHeroService.Models.Customers;

namespace ZeroToHeroService.Models.CustomerAddresses
{
    public class CustomerAddress
    {
        public Guid AddressId { get; set; }
        public Address Address { get; set; }
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
