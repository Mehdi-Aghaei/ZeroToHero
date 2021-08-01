using System;
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
