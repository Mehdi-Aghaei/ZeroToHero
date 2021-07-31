using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ZeroToHeroService.Models.BikeRentals;
using ZeroToHeroService.Models.Bikes;
using ZeroToHeroService.Models.CustomerRentals;
using ZeroToHeroService.Models.Customers;

namespace ZeroToHeroService.Models.Rentals
{
    public class Rental
    {
        public DateTimeOffset RentalBegin{ get; set; }
        public DateTimeOffset RentalEnd{ get; set; }
        public decimal TotalCost { get; set; }
        public  bool Paid { get; set; }

        [JsonIgnore]
        public IEnumerable<BikeRental> BikeRentals { get; set; }

        [JsonIgnore]
        public IEnumerable<CustomerRental> CustomerRentals { get; set; }



    }
}
