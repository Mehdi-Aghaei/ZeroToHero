using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using ZeroToHeroService.Models.Rentals;

namespace ZeroToHeroService.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<Rental> Rentals { get; set; }

        public async ValueTask<Rental> InsertRentalAsync(Rental rental)
        {
            EntityEntry<Rental> rentalEntityEntry = await this.Rentals.AddAsync(rental);
            await this.SaveChangesAsync();

            return rentalEntityEntry.Entity;
        }

        public IQueryable<Rental> SelectAllRentals() => this.Rentals.AsQueryable();

        public async ValueTask<Rental> SelectRentalByIdAsync(Guid rentalId)
        {
            this.ChangeTracker.QueryTrackingBehavior= QueryTrackingBehavior.NoTracking;

            return await this.Rentals.FindAsync(rentalId);
        }

        public async ValueTask<Rental> UpdateRentalAsync(Rental rental)
        {
            EntityEntry<Rental> rentalEntityEntry = this.Rentals.Update(rental);
            await this.SaveChangesAsync();

            return rentalEntityEntry.Entity;
        }

        public async ValueTask<Rental> DeleteRentalAsync(Rental rental)
        {
            EntityEntry<Rental> rentalEntityEntry = this.Rentals.Remove(rental);
            await this.SaveChangesAsync();

            return rentalEntityEntry.Entity;
        }
    }
}
