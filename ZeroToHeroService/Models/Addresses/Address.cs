using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZeroToHeroService.Models.Customers;

namespace ZeroToHeroService.Models.Addresses
{
    public class Address
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
        public string Town { get; set; }
        public string Street { get; set; }  
        public int HouseNumber { get; set; } 
        public int ZipCode { get; set; }
    }
}
