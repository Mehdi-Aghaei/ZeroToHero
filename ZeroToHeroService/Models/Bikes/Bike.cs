using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using ZeroToHeroService.Models.Rentals;

namespace ZeroToHeroService.Models.Bikes
{
    public class Bike
    {
        public Guid Id { get; set; }
        public Brand Brand { get; set; }
        public DateTimeOffset PurchaseDate { get; set; }
        public DateTimeOffset LastService { get; set; }
        public decimal PriceFirstHour { get; set; }
        public decimal PriceEachAdditionalHour { get; set; }
        public Category Category { get; set; }

        [JsonIgnore] 
        public IEnumerable<Rental> BikeRentals { get; set; }

    }

}
