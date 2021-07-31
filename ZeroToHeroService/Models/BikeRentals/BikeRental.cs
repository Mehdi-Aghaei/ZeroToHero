using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZeroToHeroService.Models.Bikes;
using ZeroToHeroService.Models.Rentals;

namespace ZeroToHeroService.Models.BikeRentals
{
    public class BikeRental
    {
        public Guid RentalId { get; set; }
        public Rental Rentals { get; set; }
        public Guid BikeId { get; set; }
        public Bike Bike { get; set; }
    }
}
