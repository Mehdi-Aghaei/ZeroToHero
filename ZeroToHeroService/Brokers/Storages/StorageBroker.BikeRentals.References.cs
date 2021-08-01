using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ZeroToHeroService.Models.Rentals;

namespace ZeroToHeroService.Brokers.Storages
{
    public partial class StorageBroker
    {
        private static void AddBikeRentalsReferences(ModelBuilder modelBuilder)
        {
      
            modelBuilder.Entity<Rental>()
                .HasOne(rental => rental.Bike)
                .WithMany(bike => bike.BikeRentals)
                .HasForeignKey(rental => rental.BikeId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
