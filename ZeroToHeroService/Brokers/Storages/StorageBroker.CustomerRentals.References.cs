using System;
using Microsoft.EntityFrameworkCore;
using ZeroToHeroService.Models.CustomerAddresses;
using ZeroToHeroService.Models.Rentals;

namespace ZeroToHeroService.Brokers.Storages
{
    public partial class StorageBroker
    {
        private static void AddCustomerRentalsReferences(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Rental>()
                .HasOne(rental => rental.Customer)
                .WithMany(customer => customer.CustomerRentals)
                .HasForeignKey(rental => rental.CustomerId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
