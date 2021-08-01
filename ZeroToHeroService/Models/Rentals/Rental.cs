using System;
using ZeroToHeroService.Models.Bikes;
using ZeroToHeroService.Models.Customers;

namespace ZeroToHeroService.Models.Rentals
{
    public class Rental
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
        public Guid BikeId { get; set; }
        public Bike Bike { get; set; }
        public DateTimeOffset RentalBegin{ get; set; }
        public DateTimeOffset RentalEnd{ get; set; }
        public decimal TotalCost { get; set; }
        public  bool Paid { get; set; }


    }
}
