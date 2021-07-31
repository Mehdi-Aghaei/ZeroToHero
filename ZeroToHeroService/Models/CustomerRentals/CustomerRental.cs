using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZeroToHeroService.Models.Customers;
using ZeroToHeroService.Models.Rentals;

namespace ZeroToHeroService.Models.CustomerRentals
{
    public class CustomerRental
    {

        public Guid RentalId { get; set; }
        public Rental Rentals { get; set; }
        public Guid CustomerId { get; set; }
        public  Customer Customer { get; set; }
    }
}
